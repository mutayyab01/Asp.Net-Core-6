using LoginFormAspCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace LoginFormAspCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeContext context;

        public HomeController(ILogger<HomeController> logger, EmployeeContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("email") != null)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserTable user)
        {
            var myUser = context.UserTables.Where(x => x.Email== user.Email && x.Password== user.Password).FirstOrDefault();
            //var myUser = context.UserTables.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (myUser != null)
            {
                HttpContext.Session.SetString("email", myUser.Email);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Messege = "Login Faild Please Check Your Credential"; 
            }
            return View();
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("email")!=null)
            {
                ViewBag.mysession= HttpContext.Session.GetString("email").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("email") != null)
            {
                HttpContext.Session.Remove("email");
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserTable user)
        {
            if (ModelState.IsValid)
            {
               await context.UserTables.AddAsync(user);
                await context.SaveChangesAsync();
                TempData["Success"] = "Register Successfully";

            }





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
