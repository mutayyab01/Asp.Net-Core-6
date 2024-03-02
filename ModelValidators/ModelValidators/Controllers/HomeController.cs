using Microsoft.AspNetCore.Mvc;
using ModelValidators.Models;
using System.Diagnostics;

namespace ModelValidators.Controllers
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
        [HttpPost]
        public IActionResult Index(Student std)
        {

            //if (ModelState.IsValid)
            //{
            //    return $"Name {std.Name}";
            //}
            //else
            //{
            //    return $"Error Occured Please Checked";
            //}
            ModelState.Clear();
            return View();


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
