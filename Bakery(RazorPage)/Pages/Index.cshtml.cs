using Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery_RazorPage_.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery_RazorPage_.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryContext _context;

        public IndexModel(BakeryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public Product FeaturedProduct { get; set; }
        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}