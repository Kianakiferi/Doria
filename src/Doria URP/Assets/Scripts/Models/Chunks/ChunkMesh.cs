using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Doria.URP.Models.Chunks
{
    public class ChunkMesh
    {
        // TODO: 使用 Hash 储存?
        public List<Vector3> Vertices { get; set; }
        public List<int> Triangles { get; set; }
        public List<Vector2> UV { get; set; }

        public List<Vector3> ColliderVertices { get; set; }
        public List<int> ColliderTriangles { get; set; }

        public void AddVertex(Vector3 vertex)
        {
            Vertices.Add(vertex);
        }

        public void AddVertex(Vector3 vertex, bool hasCollision)
        {
            Vertices.Add(vertex);
            if (hasCollision)
            {
                ColliderVertices.Add(vertex);
            }
        }

        public void AddQuadTriangles(bool hasCollision)
        {

            Triangles.Add(Vertices.Count - 4);
            Triangles.Add(Vertices.Count - 3);
            Triangles.Add(Vertices.Count - 2);

            Triangles.Add(Vertices.Count - 4);
            Triangles.Add(Vertices.Count - 2);
            Triangles.Add(Vertices.Count - 1);

            if (hasCollision)
            {
                ColliderTriangles.Add(Vertices.Count - 4);
                ColliderTriangles.Add(Vertices.Count - 3);
                ColliderTriangles.Add(Vertices.Count - 2);

                ColliderTriangles.Add(Vertices.Count - 4);
                ColliderTriangles.Add(Vertices.Count - 2);
                ColliderTriangles.Add(Vertices.Count - 1);

            }
        }
    }
}
