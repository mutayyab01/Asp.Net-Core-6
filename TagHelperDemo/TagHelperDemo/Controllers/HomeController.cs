using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
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
        public string Index(Employee e)
        {
            return $"Name {e.Name}\nGender {e.Gender}\n Age {e.Age}\nDesignation {e.Designation}\n Description {e.Description} \n Married {e.Married} Salary {e.salary}";
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact( )
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
