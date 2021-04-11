using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6.Entities
{
    public class ActualFeature
    {
        public int IdFeature { get; set; }
        public string FeatureName { get; set; }
        public int IdModel { get; set; }
        public virtual ModelCar ModelCar { get; set; }
    }
}
