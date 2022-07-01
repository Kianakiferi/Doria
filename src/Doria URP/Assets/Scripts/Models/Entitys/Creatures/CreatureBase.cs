using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doria.URP.Models.Entitys.Creatures
{
    public class CreatureBase : EntityBase
    {
        public Health Health { get; set; }

        public float MoveSpeed { get; set; }
    }
}
