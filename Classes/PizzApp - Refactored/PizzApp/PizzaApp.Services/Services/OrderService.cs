using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using PizzaApp.Mappers.Extensions;
using PizzaApp.Services.Services.Interfaces;
using PizzaApp.ViewModels.OrderViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<User> _userRepository;
        public OrderService(IRepository<Order> orderRepository, IRepository<User> userRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }

        public void CreateOrder(OrderViewModel model)
        {
            User userFromDb = _userRepository.GetById(model.UserId);
            Order order = model.MapToOrder();
            order.User = userFromDb ?? throw new ArgumentNullException($"User with id {model.UserId} was not found");
        }
        

        public List<OrderListViewModel> GetAllOrders()
        // dto treba tuka pa da se sprovede ponatamu 
        //maperi    web aplikacija    servisi     REFERENCI
        {
            return _orderRepository.GetAll().Select(x => x.MapToOrderListViewModel()).ToList();
        }
        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }
    }
}
