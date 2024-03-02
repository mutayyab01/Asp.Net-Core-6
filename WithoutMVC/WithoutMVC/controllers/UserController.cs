using Microsoft.AspNetCore.Mvc;

namespace WithoutMVC.controllers
{
    public class UserController : Controller
    {
        public IActionResult index1()
        {
            return View();
        }
    }
}
