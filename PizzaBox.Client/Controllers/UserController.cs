using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {

        private readonly PizzaBoxRepository _ctx;

        public UserController(PizzaBoxRepository context)
        {
            _ctx = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var user = new UserViewModel()
            {
                Users = _ctx.GetUsers()
            };

            return View("User", user);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id){

            var userHistory = new OrderHistoryViewModel();
            userHistory.User=id;

            long userId = _ctx.GetUsersId(id);

            userHistory.Orders = _ctx.getUserOrders(userId);

            
        

            return View("Select",userHistory);
        }

              
        [HttpPost]
        public IActionResult Post()
        {
            if(ModelState.IsValid){
            var user = new User();

            return View("User",user);
            }

            return View("home");

        }
    }


}