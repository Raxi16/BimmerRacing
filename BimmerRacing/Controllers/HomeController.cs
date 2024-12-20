using BimmerRacing.Areas.Identity.Data;
using BimmerRacing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BimmerRacing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BRContextDB _context;

        public HomeController(ILogger<HomeController> logger, BRContextDB context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Performance()
        {
            return View();
        }

        public IActionResult Maintenance()
        {
            return View();
        }

        public IActionResult Interior()
        {
            return View();
        }

        public IActionResult Exterior()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Cart()
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
