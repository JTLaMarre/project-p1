using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
    public class PizzaBoxRepository
    {
        private static PizzaBoxContext _ctx;

        public void newUser(User user)
        {
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
        }
        public void newOrder(Order order)
        {
            _ctx.Orders.Add(order);
            _ctx.SaveChanges();
        }

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


        public IEnumerable<APizzaModel> Pizzas()
        {
            return _ctx.Pizzas;
        }
        public long GetUsersId(string name)
        {
            var user = _ctx.Users.FirstOrDefault(u => u.Name == name);

            return user.EntityId;
        }
        public long GetStoreId(string name)
        {
            var Store = _ctx.Stores.FirstOrDefault(s => s.Name == name);

            return Store.EntityId;
        }
        public User GetUser(string Name)
        {

            return _ctx.Users.FirstOrDefault(s => s.Name == Name);
        }
        public IEnumerable<Order> getUserOrders(long id)
        {
            return _ctx.Orders.Where(o => o.UserEntityId == id);
        }
        public List<long> getStoreOrders(long id)
        {
            var orders = _ctx.Orders.Where(o => o.StoreEntityId == id);
            var orderIds = new List<long>();
            foreach (var item in orders)
            {
                orderIds.Add(item.EntityId);
            }
            return orderIds;
        }
        public IEnumerable<APizzaModel> getOrdersPizzas(long id)
        {
            return _ctx.Pizzas.Where(p => p.OrderId == id);
        }
        public string getOrdersUser(long id)
        {
            var user = _ctx.Users.FirstOrDefault(s => s.EntityId == id);
            return user.Name;
        }
        public Order getOrder(long id)
        {
            Order order = _ctx.Orders.FirstOrDefault(o => o.EntityId == id);

            return order;
        }
        public string getOrdersStore(Order order)
        {
            var store = _ctx.Stores.FirstOrDefault(s => s.EntityId == order.StoreEntityId);
            return store.Name;
        }
        public Store GetStore(string name)

        {
            return _ctx.Stores.FirstOrDefault(s => s.Name == name);
        }
        public int GetRevenue(string store)
        {
            var reference = _ctx.Stores.FirstOrDefault(s => s.Name == store);
            return reference.Revenue;
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void AddPizzas(Order order)

        {
            foreach (var pizza in order.Pizzas)
            {
                _ctx.Pizzas.Add(pizza);
            }
            _ctx.SaveChanges();
        }
        public void RemovePizza(long id)
        {
            var pizza = _ctx.Pizzas.FirstOrDefault(p => p.EntityId == id);
            _ctx.Pizzas.Remove(pizza);
            _ctx.SaveChanges();
        }
        public void RemoveOrder(long id)
        {
            var order = _ctx.Orders.FirstOrDefault(o => o.EntityId == id);
            _ctx.Orders.Remove(order);
            _ctx.SaveChanges();
        }

        // TODO: Refactor code to implement this type of abstraction
        // public IEnumerable<T> Get<T>() where T : AModel
        // {
        //   return _ctx.Set<T>().Select(t => t.GetType().GetProperty()).ToList();
        // }
    }
}