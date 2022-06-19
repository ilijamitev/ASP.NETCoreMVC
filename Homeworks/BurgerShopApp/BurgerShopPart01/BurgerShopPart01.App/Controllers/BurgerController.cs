using Microsoft.AspNetCore.Mvc;

namespace BurgerShopPart01.App.Controllers
{
    [Route("Burgers")]
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
