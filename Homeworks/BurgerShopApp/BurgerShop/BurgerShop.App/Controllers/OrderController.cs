using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.App.Controllers
{
    [Route("orders")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
