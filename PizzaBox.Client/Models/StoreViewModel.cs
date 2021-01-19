using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class StoreViewModel
    {

        [Required]
        public List<string> Stores {get;set;}
    
        public string Store {get;set;}

        public long EntityId {get;set;}

        public int Revenue {get;set;}

        public IEnumerable<Order> Orders {get;set;}

    }
}