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
        public IActionResult Get(string Store, string User)
        {
            var Order = new OrderViewModel();
           Order.Store = Store;
           Order.User =User;
           return View("Order", Order);
        }




        [HttpPost("/ContinueOrder")]
        public IActionResult ContinueOrder(string pizza,string User,string Store, string Pizzas)
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
            order.StoreEntityId=_ctx.GetStoreId(Store);
            order.UserEntityId=_ctx.GetUsersId(User);
            _ctx.newOrder(order);
            model.Pizzas = order.Pizzas;
            model.EntityId = order.EntityId;
            model.User =User; 
            model.Store = Store;
            model.StoreId=_ctx.GetStoreId(Store);

            return View("OrderContinue", model);
        }

[HttpPost("/AddPizza")]
        public IActionResult AddPizza(string pizza,string Store,string User, long EntityId,string Pizzas)
        {
        var model = new OrderViewModel();
    
        Order order = _ctx.getOrder(EntityId);
        model.Pizza = pizza;
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
            _ctx.AddPizzas(order);
             model.Order= order;
            model.Pizzas = _ctx.getOrdersPizzas(EntityId);
            model.EntityId = order.EntityId;
            model.User =User; 
            model.Store = Store;
            

            return View("AddPizza",model);
        }
    }
}