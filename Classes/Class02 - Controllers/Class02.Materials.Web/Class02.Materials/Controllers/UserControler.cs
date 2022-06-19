using Microsoft.AspNetCore.Mvc;

namespace Class02.Materials.Controllers
{
    [Route("UserApp")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("All")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return new EmptyResult();
        }
    }
}
