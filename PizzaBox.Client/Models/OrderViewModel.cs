using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
    public class OrderViewModel
    {
        public OrderViewModel(string id)
        {
            this.id = id;
        }
        public OrderViewModel(){
            
        }

        public string id { get; set; }

        public long EntityId {get;set;}

        [Required]
        public List<string> Stores { get; set; }
        [Required]
        [Range(1, 50)]
        public IEnumerable<APizzaModel> Pizzas { get; set; }

        public List<string> PizzaSelection{get;set;}
        

        public string Store { get; set;}

        public long StoreId {get;set;}

        public string User {get;set;}

        public string Pizza {get;set;}

        public Order Order {get;set;}

        public int Total {get;set;}

        public int StoreTotal{get;set;}
        
    }
}