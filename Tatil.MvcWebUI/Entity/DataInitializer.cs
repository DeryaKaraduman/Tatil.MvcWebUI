using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tatil.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {

            new Category() { Name = "Fransa", Description = "Paris Turu" },
            new Category() { Name = "Hollanda", Description = "Amsterdam Turu" },
            new Category() { Name = "İspanya", Description = "Barcelona Turu" },
            new Category() { Name = "İtalya", Description = "Venedik Turu" },

            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name="Paris Turu",Description="2 Gece 3 Gün",Price=950,Stock=20,IsApproved=true,CategoryId=1,IsHome=true,Image="1.jpg"},
                new Product(){ Name="Amsterdam Turu",Description="2 Gece 3 Gün",Price=750,Stock=20,IsApproved=true,CategoryId=2, IsHome=true,Image="2.jpg"},
                new Product(){ Name="Barcelona Turu",Description="2 Gece 3 Gün",Price=800,Stock=20,IsApproved=true,CategoryId=3,Image="3.jpg"},
                new Product(){ Name="Venedik Turu",Description="2 Gece 3 Gün",Price=750,Stock=20,IsApproved=true,CategoryId=4,IsHome=true,Image="4.jpg"}
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);

            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}