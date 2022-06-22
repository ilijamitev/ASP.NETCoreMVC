using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.App.Controllers
{
    [Route("burgers")]
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
