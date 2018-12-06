using Microsoft.EntityFrameworkCore;
using WebShop.Classes;

namespace WebShop.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
