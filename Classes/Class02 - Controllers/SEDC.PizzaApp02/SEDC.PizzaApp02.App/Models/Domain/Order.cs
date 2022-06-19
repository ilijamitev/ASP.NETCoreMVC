namespace SEDC.PizzaApp02.App.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool IsDelivered { get; set; }
    }

    public enum PaymentMethod
    {
        Cash = 1,
        CreditCard
    }
}
