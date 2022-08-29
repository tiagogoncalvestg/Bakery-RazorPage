using Bakery_RazorPage_.Data;
using Bakery_RazorPage_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bakery_RazorPage_.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BakeryContext _context;
        public OrderModel(BakeryContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Product Product { get; set; }
        public async Task OnGetAsync()
        {
            Product = await _context.Products.FindAsync(Id);
        }
    }
}
