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

        public StoreController(PizzaBoxRepository context)
        {
            _ctx = context;
        }
        [HttpGet("/stores")]
        public IActionResult Get()
        {
            var store = new StoreViewModel()
            {
                Stores = _ctx.GetStores()
            };

            return View("Store", store);
        }
        [HttpGet("/UserStore")]
        public IActionResult UserStore(string User)
        {
            var order = new OrderViewModel();
            order.User = User;
            order.Stores = _ctx.GetStores();
            return View("SelectUserStore", order);
        }
      [HttpGet("/History")]
        public IActionResult History(string Store){

            var model = new OrderHistoryViewModel();
            model.Store=Store;

            var store = _ctx.GetStore(Store);
            long storeId = _ctx.GetStoreId(Store);

            model.Orders = _ctx.getStoreOrders(storeId);
       

                   

            return View("StoreHistory",model);
        }
        [HttpGet("/sales")]
        public IActionResult StoreSales(string store)
        {
            return View("StoreSales");
        }
    }
}