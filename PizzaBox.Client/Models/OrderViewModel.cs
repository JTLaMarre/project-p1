using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace PizzaBox.Client.Models
{
    public class OrderViewModel
    {
        public OrderViewModel(string id)
        {
            this.id = id;
        }

        public string id {get;set;}

        public List<string> Stores {get;set;}
        public List<string> Pizzas {get;set;}
        
        public string Store {get;set;}

        public List<string> PizzaSelection {get;set;}

    public OrderViewModel()
    {
        Stores = new List<string>()
            {
                "LaMarrinos",
                "Meetzeronis"
            };
        Pizzas = new List<string>()
            {
                "Pepperoni",
                "Meat",
                "Four Cheese",
                "Veggie"
            };
    }
    }
}