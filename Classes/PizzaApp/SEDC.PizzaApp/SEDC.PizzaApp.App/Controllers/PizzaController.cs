using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.App.Models.Domain;

namespace SEDC.PizzaApp.App.Controllers
{
    [Route("pizza")]
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            if(pizzas == null) return NotFound();   
            return View(pizzas);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int? id)
        {
            Pizza pizza = StaticDb.Pizzas.SingleOrDefault(x => x.Id == id);
            if (pizza == null) return NotFound();   
            return View(pizza);
        }
    }
}
