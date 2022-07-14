using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.OrderViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderListViewModel> GetAllOrders();
        Order GetOrderById(int id);
        void CreateOrder(OrderViewModel model);


    }
}
