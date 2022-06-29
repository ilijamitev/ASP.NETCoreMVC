namespace BurgerShop.App.Models.Domain
{
    public class Order : BaseEntity
    {
        private static int _idGenerator = 0;
        public string FullName { get; set; }
        public string Address { get; set; }
        public List<Burger> Burgers { get; set; } = new List<Burger>();
        public string Location { get; set; } = "Skopje";
        public bool IsDelivered { get; set; } = false;

        public Order()
        {
            Id = ++_idGenerator;
        }
             
    }
}
