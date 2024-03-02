using Microsoft.AspNetCore.Mvc;

namespace ControllersandActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["data1"] ="Mutayyab";
            //ViewData["data2"] =01;
            //ViewData["data3"]= DateTime.Now.ToLongDateString();
            //ViewBag.Title = "Mutayyasadasdb";
            //ViewBag.Name = "BossProduction";

            ViewData["data1"] = null;
            ViewBag.data2 = "Mutayyab";
            TempData["data3"] = null;
            //string[] name = {"Mutayyab","imran","BSE" };

            return View();
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
    }
}
