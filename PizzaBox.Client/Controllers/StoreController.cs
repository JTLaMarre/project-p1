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
    public class  StoreController : Controller{
        
        private readonly PizzaBoxRepository _ctx;

        public StoreController(PizzaBoxRepository context){
            _ctx=context;
        }
        [HttpGet("/stores")]
        public IActionResult Get()
        {
            var store = new StoreViewModel(){
                 Stores = _ctx.GetStores()
            };
           
            return View("Store",store);
        }
        [HttpGet("/UserStore")]
        public IActionResult UserStore()
        {
            var order = new OrderViewModel();
                 order.Stores = _ctx.GetStores();
            return View("SelectUserStore",order);
        }
    }
}