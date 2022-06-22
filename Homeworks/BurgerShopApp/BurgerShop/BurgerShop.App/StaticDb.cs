using BurgerShop.App.Models.Domain;

namespace BurgerShop.App
{
    public static class StaticDb
    {
        public static List<Burger> Burgers { get; set; } = new()
        {
           new Burger("Hamburger", 150, false, false, true),
           new Burger("Cheeseburger", 180, false, false, true),
           new Burger("Vegeburger", 190, true, false, false),
           new Burger("Baconburger", 220, false, false, true),
        };

        public static List<Order> Orders { get; set; } = new()
        {
            new Order("Ilija Mitev", "Skupi bb.", new List<Burger> {Burgers[1],Burgers[2]}, "Skopje", false),
            new Order("Pink Panther", "Pinkstreet bb.", new List<Burger> {Burgers[0]}, "Hollywood", false),
            new Order("Snoopy", "Snupi bb.", new List<Burger> {Burgers[1],Burgers[3]}, "Skopje", false),
        };
    }
}
