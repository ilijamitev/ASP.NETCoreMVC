using AutoMapper;
using BurgerShop.App.Models.Domain;
using BurgerShop.App.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerShop.App.Controllers
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
        public IActionResult Index()
        {
            var ordersFromDb = StaticDb.Orders;
            if (ordersFromDb == null) return NotFound();
            var model = ordersFromDb.Select(_mapper.Map<Order, OrderViewModel>).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null) return NotFound();
            OrderDetailsViewModel model = _mapper.Map<OrderDetailsViewModel>(order);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // ***ISSUE WITH THE APPEARENCE OF THE SELECT DROPDOWN MENU IN THE VIEW ...
            ViewBag.Burgerss = new MultiSelectList(StaticDb.Burgers, "Id", "Name");  //it also works with SelectList 
            CreateOrderViewModel model = new();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderViewModel createdOrder)
        {
            ViewBag.Burgerss = new MultiSelectList(StaticDb.Burgers, "Id", "Name");
            if (ModelState.IsValid)
            {
                var order = _mapper.Map<Order>(createdOrder);
             
                foreach (var id in createdOrder.OrderedBurgers)
                {
                    Burger burger = StaticDb.Burgers.FirstOrDefault(x => x.Id == id);
                    order.Burgers.Add(burger);
                }
                StaticDb.Orders.Add(order);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            var orderViewModel = _mapper.Map<OrderViewModel>(order);
            var model = _mapper.Map<EditOrderViewModel>(order);
            ViewBag.TotalPrice = orderViewModel.TotalPrice;
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditOrderViewModel editedOrder)
        {
            if (ModelState.IsValid)
            {
                var order = StaticDb.Orders.FirstOrDefault(x => x.Id == editedOrder.Id);
                order.Address = editedOrder.Address;
                order.FullName = editedOrder.FullName;
                order.IsDelivered = editedOrder.IsDelivered;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            var model = _mapper.Map<DeleteOrderViewModel>(order);
            return View(model);
        }

        public IActionResult ConfirmDelete(int id)
        {
            var order = StaticDb.Orders.SingleOrDefault(x => x.Id == id);
            if (order is null) return NotFound();
            StaticDb.Orders.Remove(order);
            return RedirectToAction("Index");
        }
    }
}
