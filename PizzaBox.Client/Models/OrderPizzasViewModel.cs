using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Client.Models
{
    public class OrderPizzasViewModel
    {
        public OrderPizzasViewModel(){
            Pizzas = new List<APizzaModel>();
        }
        public string User {get;set;}
        public int Total {get;set;}

        public string Store {get;set;}
        
        public IEnumerable<APizzaModel> Pizzas {get;set;}

        

    }
}