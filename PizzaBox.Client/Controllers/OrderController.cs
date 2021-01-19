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
            var OrderObject = new Order();
            OrderObject.StoreEntityId=_ctx.GetStoreId(Store);
            OrderObject.UserEntityId=_ctx.GetUsersId(User);
            _ctx.newOrder(OrderObject);


            
            Order.Store = Store;
            Order.User = User;
            Order.EntityId=OrderObject.EntityId;
            
            return View("Order", Order);
        }




        [HttpPost("/ContinueOrder")]
        public IActionResult ContinueOrder( string User, string Store, string Pizzas, long EntityId)
        {
            var model = new OrderViewModel();
            
            var order = _ctx.getOrder(EntityId);
           
          
            
            model.Pizzas = _ctx.getOrdersPizzas(order.EntityId);

            model.EntityId = order.EntityId;

            model.User = User;

            model.Store = Store;
            
            model.StoreId = _ctx.GetStoreId(Store);
            
            return View("OrderContinue", model);
        }

        [HttpPost("/AddPizza")]
        public IActionResult AddPizza(string pizza, string Store, string User, long EntityId)
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
            model.Order = order;
            model.Pizzas = _ctx.getOrdersPizzas(EntityId);
            foreach (var item in model.Pizzas)
            {
                model.Total = model.Total + 10;
            }
            model.EntityId = order.EntityId;
            model.User = User;
            model.Store = Store;


            return View("AddPizza", model);
        }
        [HttpPost("/FinishOrder")]
        public IActionResult FinishOrder(string User, string Store, long EntityId)
        {
            
            var order = _ctx.getOrder(EntityId);
            var model = new OrderViewModel();
            model.Pizzas = _ctx.getOrdersPizzas(EntityId);
            foreach (var item in model.Pizzas)
            {
                model.Total = model.Total + 10;
            }
            
            model.User = User;
            model.Store = Store;
            
            var store = _ctx.GetStore(model.Store);
           model.StoreTotal = store.Revenue + model.Total;

           store.Revenue = model.StoreTotal;

            _ctx.Save();

            return View("OrderFinished", model);
        }
        [HttpPost("/RemovePizza")]
        public IActionResult RemovePizza(string Store, string User, long EntityId,long PizzaId)
        {
            _ctx.RemovePizza(PizzaId);

            var model = new OrderViewModel();

            Order order = _ctx.getOrder(EntityId);
            
            model.Pizza="none";
            model.Order = order;
            model.Pizzas = _ctx.getOrdersPizzas(EntityId);
            foreach (var item in model.Pizzas)
            {
                model.Total = model.Total + 10;
            }
            model.EntityId = order.EntityId;
            model.User = User;
            model.Store = Store;

            return View("RemovePizza",model);
        }
    }
}