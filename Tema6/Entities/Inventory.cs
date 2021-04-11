using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6.Entities
{
    public class Inventory
    {
        public int IdInventoryCar { get; set; }
        public int IdModel { get; set; }
        public virtual ModelCar Model { get; set; }
    }
}
