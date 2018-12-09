using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebShop.Classes;
using WebShop.Models.Classes;

namespace WebShop.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(
                entity =>
                {
                    entity.Property(e => e.UpdateDate)
                    .IsRequired(false);
                }    
            );

            modelBuilder.Entity<Image>(
                entity =>
                {
                    entity.HasOne(d => d.Products)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ProductId);
                }
            );

            modelBuilder.Entity<Specification>(
                entity =>
                {
                    entity.HasOne(d => d.Products)
                    .WithMany(p => p.Specifications)
                    .HasForeignKey(d => d.ProductId);
                }
            );

            modelBuilder.Entity<PaymentMethod>(
                entity =>
                {
                    entity.HasOne(d => d.Products)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.ProductId);
                }
            );
        }
    }
}
