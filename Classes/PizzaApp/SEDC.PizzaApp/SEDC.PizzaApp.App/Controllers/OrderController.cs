using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.App.Models.Domain;
using SEDC.PizzaApp.App.Models.Mappers;
using SEDC.PizzaApp.App.Models.ViewModels;

namespace SEDC.PizzaApp.App.Controllers
{
    [Route("orders")]
    public class OrderController : Controller
    {
        private readonly IMapper _mapper;

        public OrderController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDb.Orders;
            if (ordersFromDb == null) return NotFound();
            List<OrderListViewModel> model = ordersFromDb.OrderListViewModelMapper();
            return View(model);
        }

        //// USING THE AUTO MAPPER ==>
        //public IActionResult Index()
        //{
        //    List<Order> ordersFromDb = StaticDb.Orders;
        //    if (ordersFromDb == null) return NotFound();
        //    var model = _mapper.Map<List<OrderListViewModel>>(ordersFromDb);
        //    return View(model);
        //}

        //public IActionResult Index()
        //{
        //    var ordersFromDb = StaticDb.Orders;
        //    var model = new List<OrderListViewModel>();
        //    foreach (var order in ordersFromDb)
        //    {
        //        OrderListViewModel orderModel = new()
        //        {
        //            PizzaName = order.Pizza.Name,
        //            UserFullName = $"{order.User.FirstName} {order.User.LastName}",
        //        };
        //        model.Add(orderModel);
        //    }
        //    return View(model);
        //}

        [HttpGet("details/{id}")]
        public IActionResult Details(int? id)
        {
            Order requestedOrder = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            if (requestedOrder == null) return NotFound();
            var model = requestedOrder.OrderDetailsViewModelMapper();
            return View(model);
        }

        //// USING THE AUTO MAPPER ==>
        //public IActionResult Details(int? id)
        //{
        //    Order requestedOrder = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
        //    if (requestedOrder == null) return NotFound();
        //    var model = _mapper.Map<OrderDetailsViewModel>(requestedOrder);
        //    return View(model);
        //}

        [HttpGet("details/json")]
        public IActionResult GetJsonData()
        {
            return new JsonResult(StaticDb.Orders);
        }
    }
}
