﻿namespace SEDC.PizzaApp02.App.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }



    }
}