using CustomAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomAPI.Controllers
{
    public class AuthMiddlewareController : Controller
    {
        private readonly ILogger<AuthMiddlewareController> _logger;

        public AuthMiddlewareController(ILogger<AuthMiddlewareController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
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
