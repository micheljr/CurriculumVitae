using System.Diagnostics;
using CurriculumVitae2.Domain.Services;
using CurriculumVitae2.UI.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CurriculumVitae2.UI.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IErvaringService _ervaringService;
        private readonly IOpleidingService _opleidingService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IErvaringService ervaringService, IOpleidingService opleidingService)
        {
            _logger = logger;
            _ervaringService = ervaringService;
            _opleidingService = opleidingService;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Opleidingen = _opleidingService.ListOpleidingen(),
                Ervaringen = _ervaringService.ListErvaringen()
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}