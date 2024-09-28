using IFSCCode.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IFSCCode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string param)
        {
            ViewBag.param = "This is from branch  ";
            if (!string.IsNullOrWhiteSpace(param)) 
            ViewBag.param = param;

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
