using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInfoService _infoService;

        public HomeController(ILogger<HomeController> logger, IInfoService infoService)
        {
            _logger = logger;
            _infoService = infoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<TmobileInfo> Update()
        {
            var rv = await _infoService.GetInfo();

            return rv;
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