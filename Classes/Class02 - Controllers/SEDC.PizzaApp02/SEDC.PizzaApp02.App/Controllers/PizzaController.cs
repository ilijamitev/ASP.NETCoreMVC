using Microsoft.AspNetCore.Mvc;

namespace SEDC.PizzaApp02.App.Controllers
{
    [Route("app")]
    public class PizzaController : Controller
    {
        [HttpGet("All")]
        public IActionResult Index()
        {
            var pizzas = StaticDb.Pizzas;
            if (pizzas == null) return NotFound();
            return View(pizzas);
        }

        [HttpGet("pizza-details/{id}")]
        public IActionResult Details(int? id)
        {
            var pizza = StaticDb.Pizzas.SingleOrDefault(x => x.Id == id);
            return View(pizza);
        }
    }
}
