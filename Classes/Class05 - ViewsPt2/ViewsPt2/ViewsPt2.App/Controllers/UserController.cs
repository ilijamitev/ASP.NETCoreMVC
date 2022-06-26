using Microsoft.AspNetCore.Mvc;
using ViewsPt2.App.Models;

namespace ViewsPt2.App.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("user")]
        public IActionResult Index()
        {
            var user = StaticDb.Users.FirstOrDefault();
            return View(user);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                StaticDb.Users.Add(user);
                return RedirectToAction("Users");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Users()
        {
            return View(StaticDb.Users);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = StaticDb.Users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var userFromDb = StaticDb.Users.FirstOrDefault(x => x.Id == user.Id);
                userFromDb.FirstName = user.FirstName;
                userFromDb.LastName = user.LastName;
                userFromDb.Address = user.Address;
                userFromDb.PhoneNumber = user.PhoneNumber;

                return RedirectToAction("Users");
            }
            return View();
        }
    }
}
