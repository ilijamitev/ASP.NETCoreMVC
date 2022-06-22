using AutoMapper;
using SEDC.PizzaApp.App.Models.Domain;
using SEDC.PizzaApp.App.Models.ViewModels;

namespace SEDC.PizzaApp.App.Models.Mappers
{
    public class OrderAutoMapper : Profile
    {
        public OrderAutoMapper()
        {
            //CreateMap<List<Order>, List<OrderListViewModel>>();
            CreateMap<Order, OrderDetailsViewModel>();
        }

    }
}
