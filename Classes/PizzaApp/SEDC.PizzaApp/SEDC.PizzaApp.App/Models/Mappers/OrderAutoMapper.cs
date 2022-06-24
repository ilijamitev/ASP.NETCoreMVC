using AutoMapper;
using SEDC.PizzaApp.App.Models.Domain;
using SEDC.PizzaApp.App.Models.ViewModels;

namespace SEDC.PizzaApp.App.Models.Mappers
{
    // The naming of the class may not be proper but it's for learning purposes and clear distinction
    public class OrderAutoMapper : Profile
    {
        public OrderAutoMapper()
        {
            CreateMap<Order, OrderListViewModel>().ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"));
            CreateMap<Order, OrderDetailsViewModel>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address));
        }

    }
}
