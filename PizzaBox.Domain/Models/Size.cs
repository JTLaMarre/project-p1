using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Size : AEntity
    {
        public string size { get; set; }

        public Size()
        {
            size = "med";
        }

        
    }
}