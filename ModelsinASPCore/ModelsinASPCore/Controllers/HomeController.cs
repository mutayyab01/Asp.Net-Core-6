using Microsoft.AspNetCore.Mvc;
using ModelsinASPCore.Models;
using ModelsinASPCore.Repository;
using System.Diagnostics;

namespace ModelsinASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository=null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository= new StudentRepository();
        }
        public List<StudentModel> GetallStudent()
        {
            return _studentRepository.GetallStudents();
        }
        public StudentModel GetbyID(int id)
        {
            return _studentRepository.Getstudent(id);
        }
        public IActionResult Index()
        {
            //var student = new List<StudentModel>() { 
            //    new StudentModel { rollNo=1,Name="Mutayyab",Standard=12,Gender="Male"},
            //    new StudentModel { rollNo=2,Name="Muneeb",Standard=11,Gender="Male"},
            //    new StudentModel { rollNo=3,Name="Maryam",Standard=12,Gender="Female"},
            //};

            //ViewData["studends"]=student;

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
