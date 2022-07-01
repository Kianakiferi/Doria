using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Doria.URP.Models.Blocks
{
    public class BlockBase
    {
        public string Id { get; set; }
        public Vector3Int Postion { get; set; }
        public string Name { get; set; }

        public BlockType Type { get;set; }
    }
}
