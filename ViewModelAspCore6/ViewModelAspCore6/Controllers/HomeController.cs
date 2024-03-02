using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelAspCore6.Models;

namespace ViewModelAspCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeContext context;

        public HomeController(ILogger<HomeController> logger,EmployeeContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var students=context.Students.ToList();
            var teachers=context.Teachers.ToList();

            ViewModel svm = new ViewModel()
            {
                myStudent=students,
                myTeacher=teachers,
            };


            return View(svm);
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
