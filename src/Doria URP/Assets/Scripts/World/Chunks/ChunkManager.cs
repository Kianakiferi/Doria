
using System;
using System.Collections.Generic;

using UnityEngine;

using Doria.URP.Models.Chunks;
using Doria.URP.Common.Constants;

namespace Doria.URP.World.Chunks
{
    public class ChunkManager: MonoBehaviour
    {
        private static readonly ChunkGenerator chunkGenerator = new();

        private Dictionary<ChunkPostion, Chunk> Chunks = new();

        private List<Chunk> LoadedChunks = new();

        private void Start()
        {
            ChunkPostion testChunk = new(0, 0);

            GameObject chunkBaseObject = InitChunk(testChunk);
            

            //MeshFilter meshFilter = chunkBaseObject.AddComponent<MeshFilter>();
            //ChunkMeshRenderer meshRenderer = chunkBaseObject.AddComponent<ChunkMeshRenderer>();
            //MeshCollider meshCollider = chunkBaseObject.AddComponent<MeshCollider>();


            //chunkGenerator.GenerateChunkAsync(chunk);

            //Re render
        }

        private GameObject InitChunk(ChunkPostion postion)
        {
            GameObject chunk = new GameObject(postion.ToString());
            
            chunk.transform.position = GetChunkPostion(postion);
            chunk.transform.SetParent(transform, true);
            return chunk;
        }

        private Vector3Int GetChunkPostion(ChunkPostion postion) => new(
            (postion.X * ChunkConstants.ChunkWidth) + ChunkConstants.ChunkWidthHalf, 
            0, 
            (postion.Z * ChunkConstants.ChunkWidth) + ChunkConstants.ChunkWidthHalf);


    }
}
