﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Domain.Models
{
    public class PizzaOrder : BaseEntity
    {
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
