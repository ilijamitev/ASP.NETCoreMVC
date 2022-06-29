using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.App.Models.ViewModels
{
    public class EditOrderViewModel
    {
        [Display(Name = "Order id")]
        public int Id { get; set; }
        [Display(Name = "Delivered")]
        [Required(ErrorMessage = "Please select one option")]
        public bool IsDelivered { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }


    }
}
