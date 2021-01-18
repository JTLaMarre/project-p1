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
    public class PizzaController : Controller
    {

  private readonly PizzaBoxRepository _ctx;

        public PizzaController(PizzaBoxRepository context)
        {
            _ctx = context;
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {   
            var pizzas = new OrderPizzasViewModel();
            var order = _ctx.getOrder(id);
            pizzas.Pizzas = _ctx.getOrdersPizzas(id);
            pizzas.Total = order.Total;
            pizzas.Store = _ctx.getOrdersStore(order);

            return View("OrderPizzas",pizzas);
        }
        public void Post()
        {
            // need to post pizzas to db
        }
        public void Delete()
        {
            // need method for Deleting from db
        }

    }
}