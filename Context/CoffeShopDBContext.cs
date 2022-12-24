using CoffeShopManagement.Entities;
using System.Data.Entity;

namespace CoffeShopManagement.Context
{
    internal class CoffeShopDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
