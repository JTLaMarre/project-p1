using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class OrderHistoryViewModel
    {
        public OrderHistoryViewModel(){
            Orders = new List<Order>();

        }
        public string User {get;set;}

        public string Store {get;set;}
        
        public IEnumerable<Order> Orders {get;set;}

       
        

    }
}