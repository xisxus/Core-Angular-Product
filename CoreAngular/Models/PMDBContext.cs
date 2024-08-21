
using Microsoft.EntityFrameworkCore;

namespace CoreAngular.Models
{
    public class PMDBContext : DbContext
    {
        public PMDBContext(DbContextOptions<PMDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); // You can adjust the precision and scale as needed
        }

    }
}
