using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public class APizzaModel : AEntity
  {
    public string Name{ get; set;}
    public string Crust{ get; set;}
    
    public string Size { get; set; }
    public string Toppings { get; set; }

    public long OrderId{get; set;}

    protected APizzaModel()
    {
      AddName();
      AddCrust();
      AddSize();
      AddToppings();
      
    }

    protected virtual void AddName() { }
    protected virtual void AddCrust() { }
    protected virtual void AddSize() { }
    protected virtual void AddToppings() { }
    
  }
}