using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.App.Models.Domain;
using SEDC.PizzaApp.App.Models.Mappers;
using SEDC.PizzaApp.App.Models.ViewModels;

namespace SEDC.PizzaApp.App.Controllers
{
    //[Route("orders")]
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


        //[HttpGet("details/{id}")]
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

        [HttpGet("create")]
        public IActionResult Create()
        {
            ViewBag.Users = StaticDb.Users.Select(_mapper.Map<User, UserSelectViewModel>).ToList();
            OrderViewModel model = new();
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(OrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                order.Id = StaticDb.Orders.Count + 1;
                Pizza pizzaFromDb = StaticDb.Pizzas.FirstOrDefault(x => x.Name.ToLower() == order.PizzaName.ToLower());
                var newOrder = _mapper.Map<Order>(order);
                StaticDb.Orders.Add(newOrder);
                return RedirectToAction("Index");
            }
            return View();
        }

        // Create EDIT action for home
        // Add EditViewModel
        // Add view for editing orders
        // Dont't forget to populate the users list so that it will be displayed for editing
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            var model = _mapper.Map<EditOrderViewModel>(order);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditOrderViewModel editedOrder)
        {
            if (ModelState.IsValid)
            {
                var order = StaticDb.Orders.FirstOrDefault(o => o.Id == editedOrder.Id);
                order.IsDelivered = editedOrder.IsDelivered;
                order.User.FirstName = editedOrder.FirstName;
                order.User.LastName = editedOrder.LastName;
                order.User.Address = editedOrder.Address;
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return new EmptyResult();

            Order orderfromDb = StaticDb.Orders.SingleOrDefault(x => x.Id == id);
            if (orderfromDb == null) return View("ResourceNotFound");

            OrderDetailsViewModel orderDetailsViewModel = _mapper.Map<OrderDetailsViewModel>(orderfromDb);
            return View(orderDetailsViewModel);
        }

        public IActionResult ConfirmDelete(int? id)
        {
            Order orderFromDb = StaticDb.Orders.SingleOrDefault(x => x.Id == id);
            if (orderFromDb == null) return View("ResourceNotFound");
            StaticDb.Orders.Remove(orderFromDb);
            return RedirectToAction("Index");
        }


        [HttpGet("details/json")]
        public IActionResult GetJsonData()
        {
            return new JsonResult(StaticDb.Orders);
        }
    }
}
