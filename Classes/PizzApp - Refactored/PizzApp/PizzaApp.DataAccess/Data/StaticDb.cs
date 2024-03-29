﻿using PizzaApp.Domain.Enums;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Data
{
    public static class StaticDb
    {
        public static int PizzaId { get; set; }
        public static int OrderId { get; set; }
        public static int UserId { get; set; }
        public static int PizzaOrderId { get; set; }
        public static List<Pizza> Pizzas { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }

        static StaticDb()
        {
            PizzaId = 3;
            OrderId = 2;
            UserId = 2;
            PizzaOrderId = 3;

            Pizzas = new List<Pizza>
            {
                new Pizza
                {
                    Id = 1,
                    Name="Kaprichioza",
                    IsOnPromotion = true,
                    PizzaOrders = new List<PizzaOrder>
                    {


                    }
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Pepperoni",
                    IsOnPromotion = true,
                    PizzaOrders = new List<PizzaOrder>
                    {
                    }
                },
                new Pizza
                {
                    Id = 3,
                    Name="Margarita",
                    IsOnPromotion = false,
                    PizzaOrders = new List<PizzaOrder>
                    {
                    }
                },
            };

            Users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street 22",
                    Orders = new List<Order>{}
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Wayne Street 33",
                    Orders = new List<Order>{}
                }
            };

            Orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    PaymentMethod = PaymentMethod.Card,
                    IsDelivered = true,
                    Location = "Store1",
                    PizzaOrders = new List<PizzaOrder>
                    {
                        new PizzaOrder
                        {
                            Id = 1,
                            Pizza = Pizzas[0],
                            PizzaId = Pizzas[0].Id,
                            OrderId = 1
                        },
                        new PizzaOrder
                        {
                            Id = 2,
                            Pizza = Pizzas[1],
                            PizzaId = Pizzas[1].Id,
                            OrderId = 1
                        }
                    },
                    User = Users[0]
                },
                new Order
                {
                    Id = 2,
                    PaymentMethod = PaymentMethod.Cash,
                    IsDelivered = false,
                    Location = "Store2",
                    PizzaOrders = new List<PizzaOrder>
                    {
                        new PizzaOrder
                        {
                            Id = 3,
                            Pizza = Pizzas[1],
                            PizzaId = Pizzas[1].Id,
                            OrderId = 2
                        }
                    },
                    User = Users[1]
                }

            };
        }
    }
}

