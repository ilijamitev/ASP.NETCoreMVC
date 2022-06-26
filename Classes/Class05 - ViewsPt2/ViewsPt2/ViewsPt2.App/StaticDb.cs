using ViewsPt2.App.Models;

namespace ViewsPt2.App
{
    public class StaticDb
    {
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
    }
}
