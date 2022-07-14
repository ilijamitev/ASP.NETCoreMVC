using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.OrderViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Mappers.Extensions
{
    public static class OrderMapper
    {
        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            return new OrderListViewModel()
            {
                Id = order.Id,
                IsDelivered = order.IsDelivered,
                PizzaNames = order.PizzaOrders.Select(x => x.Pizza.Name).ToList(),
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
            };
        }

        public static Order MapToOrder(this OrderViewModel orderViewModel)
        {
            return new Order
            {
                Id = orderViewModel.Id,
                IsDelivered = orderViewModel.IsDelivered,
                PaymentMethod = orderViewModel.PaymentMethod,
                PizzaOrders = new List<PizzaOrder>(),
                UserId = orderViewModel.UserId,

            };
        }
    }
}
