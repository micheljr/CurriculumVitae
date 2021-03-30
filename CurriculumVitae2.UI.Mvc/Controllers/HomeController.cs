using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CurriculumVitae.Core;
using CurriculumVitae.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CurriculumVitae2.Models;

namespace CurriculumVitae2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDatabase _database;

        public HomeController(ILogger<HomeController> logger, IDatabase database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Opleidingen = _database.Opleidingen,
                Ervaringen = _database.Ervaringen
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