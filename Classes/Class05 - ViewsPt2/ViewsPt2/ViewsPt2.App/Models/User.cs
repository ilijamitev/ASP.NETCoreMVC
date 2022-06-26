using System.ComponentModel.DataAnnotations;

namespace ViewsPt2.App.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        [MinLength(8, ErrorMessage = "Please enter more than 8 characters")]
        [StringLength(maximumLength: 14)]
        public string FirstName { get; set; }

        [Display(Name = "Презиме")]
        public string LastName { get; set; }
        [Display(Name = "Адреса")]

        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
