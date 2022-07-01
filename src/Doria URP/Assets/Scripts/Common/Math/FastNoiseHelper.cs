using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doria.URP.Common.Math
{
    public class FastNoiseHelper
    {
        private readonly FastNoiseLite noise;


        public FastNoiseHelper()
        {
            noise = new FastNoiseLite();
        }

        public float[,] GetPerlinNoise(int amplitude, int frequency, int width, int height, float indexX, float indexZ)
        {
            noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);


            var result = GetNoiseArray(width, height, indexX, indexZ);

            return result;
        }

        private float[,] GetNoiseArray(int width,int height,float indexX, float indexZ)
        {
            float[,] noiseData = new float[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < height; z++)
                {
                    noiseData[x, z] = noise.GetNoise(indexX + x, indexZ + z);
                }
            }

            return noiseData;
        }
    }
}
