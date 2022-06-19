using SEDC.PizzaApp02.App.Models.Domain;

namespace SEDC.PizzaApp02.App
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
                PhoneNumber = "12345"
            },
            new User
            {
                Id=2,
                FirstName = "Petko",
                LastName = "Petkov",
                Address = "ul. Stobi bb",
                PhoneNumber = "23456"
            },
            new User
            {
                Id=3,
                FirstName = "Bob",
                LastName = "Bobsky",
                Address = "ul. Bobs bb",
                PhoneNumber = "34567"
            }
        };
        public static List<Order> Orders = new()
        {
            new Order
            {
                Id = 1,
                PaymentMethod = PaymentMethod.Cash,
                IsDelivered = false,
                Pizza = Pizzas.FirstOrDefault(x => x.Id == 2),
                User = Users.FirstOrDefault(x => x.Id == 2),
            },
            new Order
            {
                Id = 2,
                PaymentMethod = PaymentMethod.CreditCard,
                IsDelivered = true,
                Pizza = Pizzas.FirstOrDefault(x => x.Id == 3),
                User = Users.FirstOrDefault(x => x.Id == 3),
            }
        };
    }
}
