﻿namespace Class04.App.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public bool IsEmployeed { get; set; }

        public override string ToString()
        {
            return $"Hello there! I am {FirstName} {LastName}";
        }


    }
}
