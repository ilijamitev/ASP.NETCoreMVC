using System.ComponentModel.DataAnnotations;

namespace BurgerShop.App.Models.ViewModel
{
    public class EditOrderViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please select option")]
        public bool IsDelivered { get; set; }
        [Required(ErrorMessage = "Please enter Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }

        public EditOrderViewModel()
        {

        }
    }
}
