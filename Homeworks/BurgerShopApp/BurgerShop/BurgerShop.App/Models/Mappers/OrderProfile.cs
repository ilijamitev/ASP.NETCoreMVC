using AutoMapper;
using BurgerShop.App.Models.Domain;
using BurgerShop.App.Models.ViewModel;

namespace BurgerShop.App.Models.Mappers
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Burgers.Select(x => x.Price).ToList().Sum()));

            CreateMap<Burger, BurgerViewModel>();

            CreateMap<Order, OrderDetailsViewModel>()
                 .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Burgers.Select(x => x.Price).ToList().Sum()));

            CreateMap<CreateOrderViewModel, Order>();

            CreateMap<Order, EditOrderViewModel>();

            CreateMap<Order, DeleteOrderViewModel>();

            CreateMap<Burger, BurgerSelectViewModel>();

        }
    }
}
