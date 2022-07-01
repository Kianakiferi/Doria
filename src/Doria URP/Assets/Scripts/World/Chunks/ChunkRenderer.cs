using System;
using System.Collections.Generic;

using UnityEngine;

using Doria.URP.Models.Chunks;

namespace Doria.URP.World.Chunks
{
    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    [RequireComponent(typeof(MeshCollider))]
    public class ChunkRenderer : MonoBehaviour
    {
        public Chunk Chunk { get; set; }

        private static MeshFilter meshFilter;
        private static MeshCollider meshCollider;
        private static Mesh mesh;

        public bool ShowGizmo = false;

        private void Awake()
        {
            meshFilter = GetComponent<MeshFilter>();
            meshCollider = GetComponent<MeshCollider>();
            mesh = meshFilter.mesh;
        }

        public void SetChunk(Chunk data)
        {
            Chunk = data;
        }

        private void RenderMesh(ChunkMesh chunkMesh)
        {

        }
    }
}
