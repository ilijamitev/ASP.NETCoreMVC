namespace BurgerShopPart01.App.Models.Domain
{
    public class Order : BaseEntity
    {
        private int IdGenerator { get; init; } = 0;
        public string FullName { get; set; }
        public string Address { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Location { get; set; }
        public bool IsDelivered { get; set; }


        public Order(string fullName, string address, List<Burger> burgers, string location, bool isDelivered)
        {
            Id = ++IdGenerator;
            FullName = fullName;
            Address = address;
            Burgers = burgers;
            Location = location;
            IsDelivered = isDelivered;
        }
    }
}
