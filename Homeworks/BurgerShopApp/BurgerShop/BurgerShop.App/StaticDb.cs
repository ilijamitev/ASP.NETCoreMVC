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
           
            new Order()
            {
                FullName = "Ilija Mitev",
                Address = "Skupi bb.",
                Burgers = new List<Burger> {Burgers[1],Burgers[2]},
            },  
            
            new Order()
            {
                FullName = "Pink Panther",
                Address = "Pinkstreet bb.",
                Burgers = new List<Burger> {Burgers[0]},
                Location = "Hollywood",
            },  
            
            new Order()
            {
                FullName = "Snoopy",
                Address = "Snupi bb.",
                Burgers = new List<Burger> {Burgers[1],Burgers[3]},
            },
        };
    }
}
