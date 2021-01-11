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
        public IActionResult Get()
        {
            var Order = new OrderViewModel();
           ViewBag.Order = Order;
            return View("Order");
        }
        [HttpGet("{id}")]
        public IActionResult GetAction(string id)
        {
            return View("Order",new OrderViewModel(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(OrderViewModel order)
        {
            
            
            if (ModelState.IsValid)
            {   
                return View("OrderPass");
            }
            return View("OrderFail");
        }
    }
}