using AutoMapper;
using BurgerShop.App.Models.Domain;
using BurgerShop.App.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.App.Controllers
{
    [Route("burgers")]
    public class BurgerController : Controller
    {
        private readonly IMapper _mapper;
        public BurgerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var burgersFromDb = StaticDb.Burgers;
            var model = burgersFromDb.Select(_mapper.Map<Burger, BurgerViewModel>).ToList();
            return View(model);
        }
    }
}
