namespace BurgerShop.App.Models.Domain
{
    public class Order : BaseEntity
    {
        private static int _idGenerator = 0;
        public string FullName { get; set; }
        public string Address { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Location { get; set; }
        public bool IsDelivered { get; set; }


        public Order(string fullName, string address, List<Burger> burgers, string location, bool isDelivered)
        {
            Id = ++_idGenerator;
            FullName = fullName;
            Address = address;
            Burgers = burgers;
            Location = location;
            IsDelivered = isDelivered;
        }
    }
}
