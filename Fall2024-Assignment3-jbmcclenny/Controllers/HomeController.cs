using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fall2024_Assignment3_jbmcclenny.Models;

namespace Fall2024_Assignment3_jbmcclenny.Controllers
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    };
}