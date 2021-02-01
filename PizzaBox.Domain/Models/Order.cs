using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Domain.Models
{
    public class Order : AEntity
    {
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

        public List<APizzaModel> Pizzas { get; set; }
        public long UserEntityId { get; set; }

        public long StoreEntityId {get; set;}

// TODO Remove then restruct db this number Id isn't used;
        public long OrderId {get; set;}



        public int Total;

        public Order()
        {
            Pizzas = new List<APizzaModel>();
            
        }


       
        
        public void AddPizza(int choice)
        {
            

            if (choice == 1)
            {
                // check to see if amount of pizza is less than 50
                if (Pizzas.Count < 25)
                {
                    APizzaModel p =_pizzaFactory.Make<PepperoniPizza>();
                    p.OrderId=EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 2)
            {

                if (Pizzas.Count < 25)
                {
                   APizzaModel p = _pizzaFactory.Make<FourCheesePizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }

            }
            else if (choice == 3)
            {
                if (Pizzas.Count < 25)
                {
                    APizzaModel p = _pizzaFactory.Make<VeggiePizza>();
                    p.OrderId=EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 4)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<MeatPizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 5)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<MeatPizza>();
                    p.OrderId = EntityId;
                    p.Size = "Large";
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 6)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<PepperoniPizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 7)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<FourCheesePizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 8)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<VeggiePizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 0)
            {
                System.Console.WriteLine("Finished Ordering..");

            }
            else
            {
                System.Console.WriteLine("Choose a valid option");
                 }
        }
    }
}