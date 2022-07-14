using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Repositories.Interfaces
{
    // da se simplificira so toa sto mesto kaj PizzaRepository da se stavi IPizzaRepos,  IRepository<Pizza> moze vaka  =====>
    public interface IPizzaRepository : IRepository<Pizza>
    {
        List<Pizza> GetOnPromotion();
    }
}
