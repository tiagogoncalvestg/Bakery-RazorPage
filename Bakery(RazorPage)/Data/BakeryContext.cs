using Microsoft.EntityFrameworkCore;
using Bakery_RazorPage_.Models;

namespace Data
{
    public class BakeryContext:DbContext
    {
        public DbSet<Product> Products{get; set;}

        public BakeryContext(DbContextOptions options):base(options)
        {
            
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilderExtensions.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}