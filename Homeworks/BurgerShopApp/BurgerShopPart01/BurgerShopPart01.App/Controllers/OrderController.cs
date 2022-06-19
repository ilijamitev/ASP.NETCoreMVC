using Microsoft.AspNetCore.Mvc;

namespace BurgerShopPart01.App.Controllers
{
    [Route("Orders")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
