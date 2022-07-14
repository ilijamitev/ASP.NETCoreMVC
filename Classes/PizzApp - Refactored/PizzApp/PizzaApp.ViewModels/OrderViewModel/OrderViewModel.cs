using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels.OrderViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public bool IsDelivered { get; set; } = false;
        public PaymentMethod PaymentMethod { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }
    }
}
