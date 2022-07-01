using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

using Doria.URP.Common.Constants;

using System.Threading;

namespace Doria.URP.World.Chunks
{
    public class ChunkGenerator
    {
        public int Seed { get; set; }

        public float Scale = 100.0f;

        private readonly FastNoiseLite noise;

        public ChunkGenerator()
        {
            Seed = 36916070;

            noise = new FastNoiseLite(Seed);
            noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);
        }

        public float[,] GenerateChunkNoise(ChunkPostion postion)
        {
            float startIndexX = (postion.X * ChunkConstants.ChunkWidth) + 0.5f;
            float startIndexZ = (postion.Z * ChunkConstants.ChunkHeight) + 0.5f;

            //return GetPerlinNoiseArray(startIndexX, startIndexZ);
        }

        public void GenerateChunks(ICollection<Chunk> chunks)
        {
            throw new NotImplementedException();
        }

        public void GenerateChunkAsync(Chunk chunk, Action callback)
        {
            new Thread(() =>
            {

                CreateHeightMap(chunk);

                Thread.MemoryBarrier();
                callback();
                Thread.MemoryBarrier();
            }).Start();
        }

        private void CreateHeightMap(Chunk chunk)
        {
            throw new NotImplementedException();
        }




    }
}
