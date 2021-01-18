using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {

        private readonly PizzaBoxRepository _ctx;

        public OrderController(PizzaBoxRepository context)
        {
            _ctx = context;
        }

        [HttpGet]
        public IActionResult Get(string Store)
        {
            var Order = new OrderViewModel();
           Order.Store = Store;
            return View("Order", Order);
        }




        [HttpPost("/ContinueOrder")]
        public IActionResult ContinueOrder(string pizza)
        {
            var model = new OrderViewModel();
            model.Pizza = pizza;
            var order = new Order();
            switch (pizza)
            {
                case "Pepperoni Pizza":
                    order.AddPizza(1);
                    break;
                case "Four Cheese Pizza":
                    order.AddPizza(2);
                    break;
                case "Veggie Pizza":
                    order.AddPizza(3);
                    break;
                case "Meat Pizza":
                    order.AddPizza(4);
                    break;
            }
            model.Pizzas = order.Pizzas;
            _ctx.newOrder(order);
            model.EntityId = order.EntityId; 

            return View("OrderContinue", model);
        }

[HttpPost("/AddPizza")]
        public IActionResult AddPizza(string pizza,OrderViewModel order)
        {
           
            

            return View("AddPizza",order);
        }
    }
}