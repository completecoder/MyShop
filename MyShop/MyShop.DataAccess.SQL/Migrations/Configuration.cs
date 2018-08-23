namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyShop.DataAccess.SQL.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyShop.DataAccess.SQL.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //insert into AspNetRoles(id,Name)values('B9F0FF29-C97E-4832-8D3B-0950C71A0D00','Admin')
            //insert into AspNetRoles(id, Name)values('DAB9E6DA-5F7B-4714-BE64-D6E22D027C21', 'User')
            //insert into AspNetUsers(id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName)
            //values('d6ee11f5-2403-426d-8ed0-461f51bed14f', 'admin@mlifestore.com', 0, 'ANy34NKbw5U7ZtnjoseXrrL+cSSIqKm66v3XEOC2j7ICWq+hd9nqc6uNI4gz9o5MHg==', '296f8155-e4fa-451d-9d3e-2d889bf28cb6', NULL, 0, 0, NULL, 1, 0, 'admin@mlifestore.com')

            //insert into AspNetUserRoles(UserId, RoleId)values('d6ee11f5-2403-426d-8ed0-461f51bed14f', 'B9F0FF29-C97E-4832-8D3B-0950C71A0D00')

        }
    }
}
