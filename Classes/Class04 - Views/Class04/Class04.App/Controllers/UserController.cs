using Class04.App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class04.App.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new()
            {
                FirstName = "Martin",
                LastName = "Panovski",
                Age = 28,
                City = "Skopje",
                IsEmployeed = true,
            };
            return View(user);
        }
    }
}
