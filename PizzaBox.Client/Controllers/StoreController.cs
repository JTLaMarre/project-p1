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

    public class StoreController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StoreController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // each controller needs a method for each crud action
        public void Get()
        {

        }
        public void Get(string store)
        {

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