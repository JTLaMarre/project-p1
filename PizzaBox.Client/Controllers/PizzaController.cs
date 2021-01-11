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
    public class PizzaController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PizzaController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        
        public IActionResult Pizza(){
            return View();
        }
        public void Post(){
            // need to post pizzas to db
        }
        public void Delete(){
            // need method for Deleting from db
        }
      
    }
}