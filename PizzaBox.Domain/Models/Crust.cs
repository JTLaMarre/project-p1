using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Crust : AEntity
    {
        public string type { get; set; }

        public Crust()
        {
            type = "regular";
        }

        
    }
}