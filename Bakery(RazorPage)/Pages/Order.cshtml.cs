using Bakery_RazorPage_.Data;
using Bakery_RazorPage_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

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
        [BindProperty, EmailAddress, Required, Display(Name = "Your Email Address")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage = "Please supply a shipping address"), Display(Name = "Shipping Address")]
        public string OrderShipping { get; set; }
        [BindProperty, Display(Name = "Quantity")]
        public int OrderQuantity { get; set; } = 1;
        public async Task OnGetAsync()
        {
            Product = await _context.Products.FindAsync(Id);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Product = await _context.Products.FindAsync(Id);
            if (ModelState.IsValid)
            {
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
