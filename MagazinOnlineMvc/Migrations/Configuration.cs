namespace MagazinOnlineMvc.Migrations
{
    using MagazinOnlineMvc.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MagazinOnlineMvc.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MagazinOnlineMvc.Models.ProductDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

        context.Products.AddOrUpdate(i => i.name,
        new Product
        {
            name = "Pix",
            description = "Pix albastru",            
            price = 1.00M,
            numberOfProducts = 4
        },

         new Product
         {
             name = "Winterfresh",
             description = "Guma mentolata Winterfresh Original",
             price = 1.50M,
             numberOfProducts = 5
         },

         new Product
         {
             name = "Cablu HDMI",
             description = "Cablu HDMI",
             price = 10.00M,
             numberOfProducts = 2
         }       
   );
        }
    }
}
