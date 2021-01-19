using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
    public class StoreViewModel
    {

        [Required]
        public List<string> Stores {get;set;}

        public long EntityId {get;set;}

    }
}