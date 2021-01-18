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
    public class OrderController : Controller
    {

        private readonly PizzaBoxRepository _ctx;

        public OrderController(PizzaBoxRepository context){
            _ctx=context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Order = new OrderViewModel(){
                Stores = _ctx.GetStores()
            };
           
            return View("Order",Order);
        }
        // [HttpGet("{id}")]
        // public IActionResult UserOrder(string id)
        // {
        //     var model = new OrderViewModel();

        //     return View("Order",model);
        // }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(OrderViewModel order)
        {
            
            
            if (ModelState.IsValid)
            {   
                return View("OrderPass");
            }
            return View("Home");
        }
    }
}