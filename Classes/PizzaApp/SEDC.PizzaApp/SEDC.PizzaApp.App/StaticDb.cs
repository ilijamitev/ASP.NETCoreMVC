using SEDC.PizzaApp.App.Models.Domain;
using SEDC.PizzaApp.App.Models.Enums;

namespace SEDC.PizzaApp.App
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new()
        {
            new Pizza
            {Id=1,
            Name="Capri",
            Price = 200,
            IsOnPromotion=false,
            },
            new Pizza
            {Id=2,
            Name="Peperoni",
            Price = 140,
            IsOnPromotion=false,
            },
            new Pizza
            {Id=3,
            Name="Vege",
            Price=100,
            IsOnPromotion=true,
            },
        };

        public static List<User> Users = new()
        {
            new User
            {
                Id=1,
                FirstName = "Ilija",
                LastName = "Mitev",
                Address = "ul. Skupi bb",
            },
            new User
            {
                Id=2,
                FirstName = "Petko",
                LastName = "Petkov",
                Address = "ul. Stobi bb",
            },
            new User
            {
                Id=3,
                FirstName = "Bob",
                LastName = "Bobsky",
                Address = "ul. Bobs bb",
            }
        };

        public static List<Order> Orders = new()
        {
            new Order
            {
                Id = 1,
                PaymentMethod = PaymentMethod.Cash,
                IsDelivered = false,
                Pizza = Pizzas[1],
                User = Users[2],
            },
            new Order
            {
                Id = 2,
                PaymentMethod = PaymentMethod.Card,
                IsDelivered = true,
                Pizza = Pizzas[2],
                User = Users[1],
            }
        };
    }


}

