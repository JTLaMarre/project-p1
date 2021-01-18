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


        [Required]
        public List<string> Stores { get; set; }
        [Required]
        [Range(1, 50)]
        public List<string> Pizzas { get; set; }

        public string Store { get; set;}

        public string User {get;set;}

        public string Pizza {get;set;}

        
    }
}