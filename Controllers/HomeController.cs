using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotnetTutorial.Models;
using DotnetTutorial.services;

namespace DotnetTutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private YoService _yoService;

        public HomeController(ILogger<HomeController> logger,YoService yoService)
        {
            _logger = logger;
            _yoService=yoService;
        }

        public IActionResult Index()
        {
            @ViewBag.data=_yoService.GetUser().ToList();
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
