using Microsoft.AspNetCore.Mvc;
using PXLProShopper04.Models;
using System.Diagnostics;

namespace PXLProShopper04.Controllers
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
            // wanneer men niet is ingelogd is het guest
            // indien logging system er is: naam van de gebruiker tonen
            string username = "Guest";
            ViewData["Username"] = username;
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