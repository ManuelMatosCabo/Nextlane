using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        // Override OnModelCreating to configure relationships and seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the relationship between Customer and Order
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            // Call the method to seed data
            SeedDatabase(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            // Seeding Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Name = "Manuel Matos Cabo" },
                new Customer { CustomerId = 2, Name = "Manuel Maria" }
            );

            // Seeding Orders (make sure to only set the CustomerId)
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, Product = "P1", Price = 10M, CustomerId = 1 },
                new Order { OrderId = 2, Product = "P2", Price = 20M, CustomerId = 1 },
                new Order { OrderId = 3, Product = "P3", Price = 30M, CustomerId = 2 }
            );
        }
    }
}
