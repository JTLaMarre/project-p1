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
        
    }

}