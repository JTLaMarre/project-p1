using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class PepperoniPizza : APizzaModel
  {
   protected override void AddName()
        {
          Name = "Pepperoni Pizza";
        }
     protected override void AddCrust()
    {
      Crust C = new Crust();
      Crust = C.type;
    }

    protected override void AddSize()
    {
      Size S = new Size();
      Size = S.size;
    }
    protected override void AddToppings()
    {
     Toppings T = new Toppings();
      T.toppings = "Pepperoni, Sauce";
      Toppings = T.toppings;
    }
  }
}