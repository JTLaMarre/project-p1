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
[Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public OrderController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet]
        public IActionResult Order(){
            var stores = new StoreViewModel();
             ViewBag.Stores = stores.Stores;
            return View();
        }
        public void Post(){
            // todo submit an order
        }
    }
}