using Microsoft.AspNetCore.Mvc;
using VIEWImport.Models;

namespace VIEWImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>() {
                new Student (){StudID=1,StudName="Mutayyab",Gender="Male"},
                  new Student (){StudID=2,StudName="Muneeb",Gender="Male"},
                    new Student (){StudID=3,StudName="Moiz",Gender="Male"},
            };



            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>() {
                new Student (){StudID=1,StudName="Mutayyab",Gender="Male"},
                  new Student (){StudID=2,StudName="Muneeb",Gender="Male"},
                    new Student (){StudID=3,StudName="Moiz",Gender="Male"},
            };



            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>() {
                new Student (){StudID=1,StudName="Mutayyab",Gender="Male"},
                  new Student (){StudID=2,StudName="Muneeb",Gender="Male"},
                    new Student (){StudID=3,StudName="Moiz",Gender="Male"},
            };



            return View(students);
        }
    }
}
