namespace BurgerShop.App.Models.ViewModel
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public bool IsDelivered { get; set; }
        public string FullName { get; set; }
        public double TotalPrice { get; set; }
    }
}
