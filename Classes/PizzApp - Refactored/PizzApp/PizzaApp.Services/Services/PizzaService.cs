using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Mappers.Extensions;
using PizzaApp.Services.Services.Interfaces;
using PizzaApp.ViewModels.PizzaViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        // PODOBRA VARIJANTA
        //public IEnumerable<PizzaViewModel> GetPizzaOnPromotion()
        //{
        //    return _pizzaRepository.GetOnPromotion().Select(x => x.MapToPizzaViewModel()).ToList();
        //}        
        public List<PizzaViewModel> GetPizzaOnPromotion()
        {
            return _pizzaRepository.GetOnPromotion().Select(x => x.MapToPizzaViewModel()).ToList();
        }
    }
}
