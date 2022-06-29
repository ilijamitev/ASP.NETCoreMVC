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
            CreateMap<Order, OrderListViewModel>()
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<Order, OrderDetailsViewModel>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address))
                .ForMember(dest => dest.PizzaPrice, opt => opt.MapFrom(src => src.IsDelivered ? src.Pizza.Price - 30 : src.Pizza.Price));

            CreateMap<User, UserSelectViewModel>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => $"{x.FirstName} {x.LastName}"));

            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(x => x.Id)).ReverseMap();

            CreateMap<Order, EditOrderViewModel>()
                .ForMember(dest => dest.IsDelivered, opt => opt.MapFrom(x => x.IsDelivered))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address));

        }

    }
}
