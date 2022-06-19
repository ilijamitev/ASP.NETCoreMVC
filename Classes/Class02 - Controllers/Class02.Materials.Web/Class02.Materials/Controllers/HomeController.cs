using Microsoft.AspNetCore.Mvc;

namespace Class02.Materials.Controllers
{
    [Route("AppHome/[Action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public int Privacy()
        //{
        //    return 213213;
        //}
        public IActionResult Privacy()
        {
            return View("Privacy");  // ke go dade index t.e. home i koga ke kliknes na privacy
        }

        public IActionResult EmptyRoute()
        {
            return new EmptyResult();
        }

        public IActionResult TakeMeToPrivacyPage()
        {
            return RedirectToAction("Privacy");
        }

        public IActionResult JsonResult()
        {
            var user = new { Id = 1, FullName = "Ilija Mitev", Age = 26 };
            return new JsonResult(user);
        }

        public IActionResult TakeMeToUserPage()
        {
            return RedirectToAction("Index", "User");
        }

    }
}
