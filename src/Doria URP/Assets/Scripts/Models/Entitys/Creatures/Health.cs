using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doria.URP.Models.Entitys.Creatures
{
    public class Health
    {
        public float HealthValue { get; set; }

        public float HealthMaximum { get; set; }

        public float HealthPercentage { get => HealthValue / HealthMaximum; }
        
    }
}
