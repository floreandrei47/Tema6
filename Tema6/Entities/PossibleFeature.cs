using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6.Entities
{
    public class PossibleFeature
    {
        public int IdPossibleFeature { get; set; }
        public string PossibleFeatureName { get; set; }
        public int IdModel { get; set; }
        public virtual ModelCar ModelCar { get; set; }
    }
}
