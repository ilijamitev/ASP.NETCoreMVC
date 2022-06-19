namespace BurgerShopPart01.App.Models.Domain
{
    public class Burger : BaseEntity
    {
        private int IdGenerator { get; init; } = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }


        public Burger(string name, double price, bool isVegeterian, bool isVegan, bool hasFries)
        {
            Id = ++IdGenerator;
            Name = name;
            Price = price;
            IsVegeterian = isVegeterian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
