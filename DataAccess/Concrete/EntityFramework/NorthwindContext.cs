using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context: db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;");
        }
    }
}