using SEDC.PizzaApp.App.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.App.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza name")]
        [Required(ErrorMessage ="Please enter pizza name.")]
        public string PizzaName { get; set; }
        [Display(Name = "Payment method")]
        [Required(ErrorMessage = "Please select a payment method.")]
        public PaymentMethod PaymentMethod { get; set; }
        public int UserId { get; set; }

        public OrderViewModel()
        {

        }
    }
}
