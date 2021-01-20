using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class UserViewModel
    {
        
        public List<string> Users {get;set;}
        
        public string User{get;set;}
        public IEnumerable<Order> Orders {get;set;}

       
    }
}