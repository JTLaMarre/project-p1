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
    public class StoreController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StoreController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // think about CRUD when building controllers 
        [HttpGet]
        public IActionResult Get()
        {
            var stores = new StoreViewModel();
            // three different ways to bind the data 

            ViewBag.Stores = stores.Stores; // dynamic object 

            // dictionary object    
            // ViewData["Stores"]=stores.Stores; 


            // for when response is a redirect
            // TempData["Stores"]=stores.Stores; 

            return View("Store");
        }
        [HttpGet("{store}")] //http:localhost5000/store/{store}
        public IActionResult Get(string store)
        {
            return View("Store",store); //returnin an action result
        }
        // Don't need these for Store since Out customer isn't doing these
        // public void Post()
        // public void Put()
        // public void Delete()
        

        public IActionResult StoreList()
        {
            return View();
        }

    }
}