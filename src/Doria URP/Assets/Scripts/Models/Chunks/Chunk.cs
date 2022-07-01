using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

using Doria.URP.Models.Blocks;

namespace Doria.URP.Models.Chunks
{
    public class Chunk
    {
        public List<Section> BlockSections { get; set; }
        public Worlds.World World { get; set; }
        public ChunkPostion ChunkPostion { get; set; }
        public Vector3Int ChunkPostionVector { get; set; }

        public ChunkMesh ChunkMesh { get; set; }

        public ChunkMesh WaterMesh { get; set; }

        public bool IsPlayerModified = false;

        public Chunk(Worlds.World world, ChunkPostion chunkPostion)
        {
            World = world;
            ChunkPostion = chunkPostion;
        }
    }

    public struct ChunkPostion
    {        
        public int X { get; set; }
        public int Z { get; set; }
        public ChunkPostion(int x, int z)
        {
            X = x;
            Z = z;
        }
        public override string ToString() => $"[{X}, {Z}]";
        
    }
}
