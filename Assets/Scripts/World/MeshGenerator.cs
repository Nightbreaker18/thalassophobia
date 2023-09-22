using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    public class MeshGenerator : MonoBehaviour
    {

    }

    public class CreatedMesh
    {
        public Vector3 centerPos;
        public int width, height;

        public CreatedMesh(MeshRenderer renderer, Vector3 centerPos, int width, int height)
        {
            this.centerPos = centerPos;
            this.width = width;
            this.height = height;
            GenerateMesh(renderer);
        }

        public void GenerateMesh(MeshRenderer renderer)
        {
            Mesh mesh = new Mesh();
        }
    }
}
