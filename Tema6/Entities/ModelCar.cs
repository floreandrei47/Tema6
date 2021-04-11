using System;
using System.Collections.Generic;
using System.Text;
using Tema6.Interfaces;

namespace Tema6.Entities
{
   public class ModelCar: IEntity
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
        public int IdBrand { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
