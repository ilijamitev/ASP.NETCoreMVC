using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.PizzaViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Mappers.Extensions
{
    public static class PizzaMapper
    {
        public static PizzaViewModel MapToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
            };
        }
    }
}
