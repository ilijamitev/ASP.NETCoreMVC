namespace BurgerShopPart01.App.Models.Domain
{
    public class Burger : BaseEntity
    {
        private static int _idGenerator = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }


        public Burger(string name, double price, bool isVegeterian, bool isVegan, bool hasFries)
        {
            Id = ++_idGenerator;
            Name = name;
            Price = price;
            IsVegeterian = isVegeterian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
