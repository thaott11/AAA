using Microsoft.AspNetCore.Mvc;

namespace CustomAPI.Controllers
{
    public class portalsController : Controller
    {
        public IActionResult PortalsView()
        {
            return View();
        }
    }
}
