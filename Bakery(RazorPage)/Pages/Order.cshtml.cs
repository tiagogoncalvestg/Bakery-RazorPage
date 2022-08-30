using Bakery_RazorPage_.Data;
using Bakery_RazorPage_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;

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
                var body = $@"<p>Thank you, we have received your order for 
                    {OrderQuantity} unit(s) of {Product.Name}!</p>
                    <p>Your address is: <br/>{OrderShipping.Replace("\n", "<br/>")}</p>
                    Your total is ${Product.Price * OrderQuantity}.<br/>
                    We will contact you if we have questions about your order.  Thanks!<br/>";
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "testes@hotmail.com",  // replace with valid value
                        Password = "********8"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "Fourth Coffee - New Order";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("example@gmail.com");
                    await smtp.SendMailAsync(message);
                }

                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
