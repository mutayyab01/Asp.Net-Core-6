using Microsoft.AspNetCore.Mvc;
using PartialViewAspCore6.Models;
using System.Diagnostics;

namespace PartialViewAspCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>() {
                new Product(){ID=101,Name="Rebook Shoes",Description="A shoes with amazing Soul",Price=10000.00,Image="~/Images/Shoes.jpg"},
                new Product(){ID=102,Name="Bulb",Description="A Bulb with amazing Light",Price=300.00,Image="~/Images/Bulb.jpg"},
                new Product(){ID=103,Name="Soap",Description="A Soap with amazing Bubbles",Price=100.00,Image="~/Images/Soap.jpg"},
                new Product(){ID=104,Name="Sun Glasses",Description="A Sun Glasses Which protect from light",Price=150.00,Image="~/Images/Sunglasses.jpg"},
            };

            return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
