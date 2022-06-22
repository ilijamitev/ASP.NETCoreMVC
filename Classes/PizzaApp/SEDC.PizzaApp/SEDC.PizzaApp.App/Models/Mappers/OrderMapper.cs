using SEDC.PizzaApp.App.Models.Domain;
using SEDC.PizzaApp.App.Models.ViewModels;

namespace SEDC.PizzaApp.App.Models.Mappers
{
    public static class OrderMapper
    {
        public static List<OrderListViewModel> OrderListViewModelMapper(this List<Order> orders)
        {
            var ordersList = new List<OrderListViewModel>();
            foreach (var order in orders)
            {
                ordersList.Add(new OrderListViewModel(order.Pizza.Name, $"{order.User.FirstName} {order.User.LastName}"));
            }
            return ordersList;
        }
        public static OrderDetailsViewModel OrderDetailsViewModelMapper(this Order order)
        {
            return new OrderDetailsViewModel()
            {
                OrderId = order.Id,
                FullName = $"{order.User.FirstName} {order.User.LastName}",
                Address = order.User.Address,
                PizzaName = order.Pizza.Name,
                PizzaPrice = order.Pizza.Price,
                IsDelivered = order.IsDelivered,
            };
        }
    }
}
