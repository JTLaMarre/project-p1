using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing
{
  public class PizzaBoxRepository
  {
    private PizzaBoxContext _ctx;

    public PizzaBoxRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    public List<string> GetStores()
    {
      return _ctx.Stores.Select(s => s.Name).ToList();
    }
    public List<string> GetUsers()
    {
      return _ctx.Users.Select(u => u.Name).ToList();
    }

    // TODO: Refactor code to implement this type of abstraction
    // public IEnumerable<T> Get<T>() where T : AModel
    // {
    //   return _ctx.Set<T>().Select(t => t.GetType().GetProperty()).ToList();
    // }
  }
}