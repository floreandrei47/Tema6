using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6.Entities
{
    class PotentialCustomer
    {
        public int IdPossibleCustomer { get; set; }
        public string PossibleCustomerName { get; set; }
        public int PossibleCustomerPhone { get; set; }
        public int IdModel { get; set; }
        public System.DateTime InteresDate { get; set; }
        public virtual ModelCar Model { get; set; }
    }
}
