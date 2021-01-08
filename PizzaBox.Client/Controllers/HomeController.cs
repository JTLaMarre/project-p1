using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // IActionResult returns interfaces
        public IActionResult Index() //HTTP verb?
        {
            return View(); // nop view specified so it tried to find a view with same name of the action
            // HTTP status code --
            //  100s (network info),
            //  200s (succesful responses)
            //  300s(redirection responses due to availability)
            //  400s (incorrect requests responses)
            // 500s (incorrect route mapping responses)
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
