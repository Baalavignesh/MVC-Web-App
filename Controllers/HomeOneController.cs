using Microsoft.AspNetCore.Mvc;
using MVC_Web_App.Models;
using System.Diagnostics;

namespace MVC_Web_App.Controllers
{
    public class HomeOneController : Controller
    {
        private readonly ILogger<HomeOneController> _logger;

        public HomeOneController(ILogger<HomeOneController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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