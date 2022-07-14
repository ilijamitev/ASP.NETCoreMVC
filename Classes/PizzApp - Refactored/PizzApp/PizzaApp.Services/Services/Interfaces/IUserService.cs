using PizzaApp.ViewModels.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Services.Interfaces
{
    public interface IUserService
    {
        public List<UserViewModel> GetUsersForDropdown();

    }
}
