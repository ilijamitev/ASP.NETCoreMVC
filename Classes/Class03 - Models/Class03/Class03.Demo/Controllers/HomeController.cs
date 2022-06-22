using Class03.Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Class03.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult GetUserById(int id)
        {
            User user = StaticDb.Users.SingleOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }

        public IActionResult GetUserByName(string firstName)
        {
            User user = StaticDb.Users.FirstOrDefault(u => u.FirstName == firstName);
            if (user == null) return NotFound();
            return View("GetUserById", user);
        }

        public IActionResult DisplayName(string firstName)
        {
            User user = StaticDb.Users.FirstOrDefault(u => u.FirstName == firstName);
            if (user == null) return NotFound();
            // sending primitive type
            ViewData.Add("FirstName", firstName);
            // sending complex type
            //ViewData.Add("User", user);
            return View();
        }

        public IActionResult DisplayData(int? id)
        {
            User user = StaticDb.Users.SingleOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            ViewBag.User = user;
            ViewBag.TodaysDate = DateTime.Now.ToShortDateString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}