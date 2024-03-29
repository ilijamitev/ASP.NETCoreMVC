﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels.OrderViewModel
{
    public class OrderListViewModel
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public bool IsDelivered { get; set; }
        public List<string> PizzaNames { get; set; }
    }
}
