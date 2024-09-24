using Microsoft.AspNetCore.Mvc;

namespace CustomAPI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }


        public new IActionResult User()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
    }
}
