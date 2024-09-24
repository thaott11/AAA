using Microsoft.AspNetCore.Mvc;

namespace CustomAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ProductDetail()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View();
        }
    }
}
