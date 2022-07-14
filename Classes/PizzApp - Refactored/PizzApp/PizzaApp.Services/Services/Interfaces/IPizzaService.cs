using PizzaApp.ViewModels.PizzaViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaViewModel> GetPizzaOnPromotion();
    }
}
