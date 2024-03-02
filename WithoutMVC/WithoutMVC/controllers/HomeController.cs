using Microsoft.AspNetCore.Mvc;

namespace WithoutMVC.controllers
{
    [Route("[controller]/[action]")]

    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("~/home")]    
        //[Route("~/home/index")]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ABout()
        {
            return View();
        }
        [Route("{id?}")]

        public int Details(int? id)
        {
            return id??10;
        }
    }
}
