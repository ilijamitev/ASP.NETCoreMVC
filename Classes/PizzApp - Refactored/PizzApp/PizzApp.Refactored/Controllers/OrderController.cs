using Microsoft.AspNetCore.Mvc;
using PizzaApp.Mappers.Extensions;
using PizzaApp.Services.Services.Interfaces;
using PizzaApp.ViewModels.OrderViewModel;

namespace PizzApp.Refactored.Controllers
{

    // Connect MVC Application with Database using EF
    // 1. Install nuget packages for EF.Core
    // 2. Implement DbContext class with all the db sets and relation confiqs
    // 3. Add the dbContext in Program.cs class
    // 4. Inject the dbContext in the Repositories and use it
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            List<OrderListViewModel> orderListViewModel = _orderService.GetAllOrders();
            return View(orderListViewModel);
        }

        public IActionResult Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            ViewBag.Users = _userService.GetUsersForDropdown();
            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            try
            {
                _orderService.CreateOrder(orderViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                // We can add loggs here
                return View("ExceptionPage");
            }
        }
    }
}
