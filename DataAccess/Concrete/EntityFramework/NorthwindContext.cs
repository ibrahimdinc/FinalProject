using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // context : Db tabloları ile proje classlarını bağlama
    // DbContext EntityFrameworkCore dan geliyor.  DataAccess e kurduğumuz.

    public class NorthwindContext:DbContext
    {
        // burası projenin hangi veritabanıyla ilişkili oldugunuz belirttiğimiz bölüm
        // @ \ ' ın C# da anlamı var. o anlamı dışında normal kullanmak için başına @ koyuyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        // hangi class'ın db deki hangi kısıma karşılık geldiği
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
