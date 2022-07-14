using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Mappers.Extensions
{
    public static class UserMapper
    {
        public static UserViewModel MapToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
