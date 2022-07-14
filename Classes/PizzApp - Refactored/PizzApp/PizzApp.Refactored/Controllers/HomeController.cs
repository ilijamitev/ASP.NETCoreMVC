using Microsoft.AspNetCore.Mvc;
using PizzaApp.Services.Services.Interfaces;
using PizzaApp.ViewModels.HomeViewModel;

namespace PizzApp.Refactored.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IPizzaService _pizzaService;

        public HomeController(IOrderService service, IPizzaService pizzaService)
        {
            _orderService = service;
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new();
            homeViewModel.OrderCount = _orderService.GetAllOrders().Count;
            homeViewModel.PizzaOnPromotion = string.Join(", ", _pizzaService.GetPizzaOnPromotion().Select(x => x.Name));
            return View(homeViewModel);
        }
    }
}
