using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webby.Models;

namespace webby.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Retrieve the email and name from TempData
            var userEmail = Request.Cookies["UserEmail"];
            var userName = Request.Cookies["UserName"];
            var sessionKey = Request.Cookies["UserEmail"];

            // Pass the email and name to the Index view
            ViewBag.UserEmail = userEmail;
            ViewBag.UserName = userName;
            ViewBag.SessionKey = sessionKey;

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