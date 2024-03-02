using BindDropDownlistWithDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace BindDropDownlistWithDatabase.Controllers
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

        private StudentModel BindDDL()
        {
            StudentModel studentModels = new StudentModel();
            studentModels.StudentList = new List<SelectListItem>();

            var data = context.Students.ToList();
            studentModels.StudentList.Add(new SelectListItem
            {
                Text = "Select Name",
                Value = "",
            });
            foreach (var item in data)
            {
                studentModels.StudentList.Add(new SelectListItem
                {
                    Text = item.StudentName,
                    Value = item.Id.ToString(),
                });
            }
            return studentModels;
        }
        public IActionResult Index()
        {
       
            return View(BindDDL());
        }
        [HttpPost]
        public IActionResult Index(StudentModel student)
        {
            BindDDL();
            var std = context.Students.Where(x => x.Id == student.ID).FirstOrDefault();
            if (std!=null)
            {
                ViewBag.selectValue = std.StudentName;
            }
            return View(BindDDL());
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
