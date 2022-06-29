using BurgerShop.App.Models.Domain;

namespace BurgerShop.App.Models.ViewModel
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public bool IsDelivered { get; set; }
        public string Location { get; set; }
        public double TotalPrice { get; set; } 

        public string FullName { get; set; }
        public string Address { get; set; }

        public List<BurgerViewModel> Burgers { get; set; }

    }
}
