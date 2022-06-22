namespace SEDC.PizzaApp.App.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PizzaName { get; set; }
        public double PizzaPrice { get; set; }
        public bool IsDelivered { get; set; }
    }
}
