using Microsoft.EntityFrameworkCore;
using Bakery_RazorPage_.Models;

namespace Bakery_RazorPage_.Data
{
    public class BakeryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public BakeryContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}