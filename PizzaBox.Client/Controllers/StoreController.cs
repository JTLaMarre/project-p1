using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
[Route("[controller]")]
    public class StoreController : Controller
    {
        
        private readonly PizzaBoxRepository _ctx;

        // think about CRUD when building controllers 
        [HttpGet]
        public IActionResult Get()
        {   
            var s = new StoreViewModel(){
                Stores=_ctx.GetStores()
            };
            return View("Store",s);
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