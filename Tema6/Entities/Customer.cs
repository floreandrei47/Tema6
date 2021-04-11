using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6.Entities
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string CustomerName { get; set; }
        public int CustomerPhone { get; set; }
        public int IdModel { get; set; }
        public virtual ModelCar Model { get; set; }
    }
}