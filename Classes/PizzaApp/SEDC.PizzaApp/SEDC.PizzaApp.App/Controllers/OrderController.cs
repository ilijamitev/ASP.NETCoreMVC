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
        // USING THE AUTO MAPPER ==>
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDb.Orders;
            if (ordersFromDb == null) return NotFound();
            var model = ordersFromDb.Select(_mapper.Map<Order, OrderListViewModel>).ToList();
            ViewData["Title"] = $"Orders list";
            ViewData["Message"] = $"We have total orders of {model.Count}";
            return View(model);
        }

        #region USING HARDCODE MAPPER ==>
        //public IActionResult Index()
        //{
        //    List<Order> ordersFromDb = StaticDb.Orders;
        //    if (ordersFromDb == null) return NotFound();
        //    List<OrderListViewModel> model = ordersFromDb.MapToOrderListViewModel();
        //    ViewData["Message"] = $"We have total orders of {model.Count}";
        //    ViewData["Title"] = $"Orders list";
        //    // sekogas da se stava ? pred da povikam properti ... vo slucaj ako nema first user
        //    ViewData["FirstUser"] = $"Our very first user in the system is {StaticDb.Users.First()?.FirstName} ";
        //    return View(model);
        //}
        #endregion

        #region BAD WAY FOREACH ==>
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
        #endregion


        [HttpGet("details/{id}")]
        // USING THE AUTO MAPPER ==>
        public IActionResult Details(int? id)
        {
            Order requestedOrder = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            if (requestedOrder == null) return NotFound();
            var model = _mapper.Map<OrderDetailsViewModel>(requestedOrder);
            return View(model);
        }

        #region USING HARDCODED MAPPER
        //public IActionResult Details(int? id)
        //{
        //    Order requestedOrder = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
        //    if (requestedOrder == null) return NotFound();
        //    var model = requestedOrder.MapToOrderDetailsViewModel();
        //    return View(model);
        //}
        #endregion

        [HttpGet("details/json")]
        public IActionResult GetJsonData()
        {
            return new JsonResult(StaticDb.Orders);
        }
    }
}
