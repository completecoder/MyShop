using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.InMemory
{
    public class ProductCategoryRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ProductCategory> productsCategory = new List<ProductCategory>();

        public ProductCategoryRepository()
        {
            productsCategory = cache["productsCategory"] as List<ProductCategory>;

            if (productsCategory == null)
            {
                productsCategory = new List<ProductCategory>();
            }
        }

        public void Commit()
        {
            cache["productsCategory"] = productsCategory;
        }

        public void Insert(ProductCategory p)
        {
            productsCategory.Add(p);
        }

        public void Update(ProductCategory product)
        {
            ProductCategory productToUpdate = productsCategory.Find(p => p.Id == product.Id);

            if (productToUpdate != null)
            {
                productToUpdate = product;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public ProductCategory Find(string Id)
        {
            ProductCategory product = productsCategory.Find(p => p.Id == Id);

            if (product != null)
            {
                return product;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public IQueryable<ProductCategory> Collection()
        {
            return productsCategory.AsQueryable();
        }

        public void Delete(string Id)
        {
            ProductCategory productToDelete = productsCategory.Find(p => p.Id == Id);

            if (productToDelete != null)
            {
                productsCategory.Remove(productToDelete);
            }
            else
            {
                throw new Exception("Product not found");
            }
        }
    }
}
