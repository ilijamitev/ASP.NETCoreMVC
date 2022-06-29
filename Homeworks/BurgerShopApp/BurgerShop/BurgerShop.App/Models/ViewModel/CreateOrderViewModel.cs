using BurgerShop.App.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace BurgerShop.App.Models.ViewModel
{
    public class CreateOrderViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        public string FullName { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
        [Display(Name = "Select Burgers")]
        [Required(ErrorMessage = "Please select Burger")]
        public List<int> OrderedBurgers { get; set; } = new List<int>();


        public CreateOrderViewModel()
        {

        }
    }
}
