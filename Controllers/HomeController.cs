using System.Diagnostics;
using System.Drawing;
using clickbuttonchangebg.Models;
using Microsoft.AspNetCore.Mvc;

namespace clickbuttonchangebg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string color = "white")
        {
            ViewBag.BackgroundColor = color;
            return View();
        }

        [HttpPost]
        public IActionResult Check(string bttn)
        {
            return RedirectToAction("Index", new { color = bttn });
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
