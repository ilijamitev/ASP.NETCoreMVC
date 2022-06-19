using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp02.App.Models.Domain;

namespace SEDC.PizzaApp02.App.Controllers
{
    [Route("Orders")]
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(StaticDb.Orders);
        }

        [HttpGet("details")]
        public IActionResult Details()
        {
            return new EmptyResult();
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int? id)
        {
            Order requestedOrder = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            if (requestedOrder == null) return RedirectToAction("Index", "Orders");
            return View(requestedOrder);
        }

        [HttpGet("details/json")]
        public IActionResult GetJsonData()
        {
            return new JsonResult(StaticDb.Orders);
        }
    }
}
