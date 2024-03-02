using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
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
            //Employee employee = new Employee()
            //{
            //    Empid = 101,
            //    EmpName = "Mutayyab",
            //    Designation = "Manager",
            //    Salary = 100000,
            //};


            var myEmploree = new List<Employee>()
            {
                new Employee(){ Empid = 1,EmpName="Mutayyab",Designation="Manager",Salary=1000,},
                new Employee(){ Empid = 1,EmpName="Maryan",Designation="Manager",Salary=1000,},
                new Employee(){ Empid = 1,EmpName="Muneeb",Designation="Manager",Salary=1000,},
                new Employee(){ Empid = 1,EmpName="Mobeen",Designation="Manager",Salary=1000,}
            };








            ViewData["myemployee"] = myEmploree;
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
