using PizzaApp.DataAccess.Data;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        public List<Order> GetAll()
        {
            return StaticDb.Orders;
        }

        public Order GetById(int id)
        {
            return StaticDb.Orders.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            entity.Id = ++StaticDb.OrderId;
            StaticDb.Orders.Add(entity);
        }

        public void Update(Order entity)
        {
            var orderDb = StaticDb.Orders.SingleOrDefault(x => x.Id == entity.Id);
            var index = StaticDb.Orders.IndexOf(orderDb);
            StaticDb.Orders[index] = entity;
        }

        public void Delete(int id)
        {
            Order? orderDb = StaticDb.Orders.SingleOrDefault(x => x.Id == id);
            StaticDb.Orders.Remove(orderDb);
        }
    }
}
