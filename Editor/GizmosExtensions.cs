using System;
using UnityEngine;

namespace FAS.Extensions
{
    public static class GizmosExtensions
    {
        public static void DrawCube(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            Matrix4x4 cubeTransform = Matrix4x4.TRS(position, rotation, scale);
            Matrix4x4 oldGizmosMatrix = Gizmos.matrix;
            Gizmos.matrix *= cubeTransform;
            Gizmos.DrawCube(Vector3.zero, Vector3.one);
            Gizmos.matrix = oldGizmosMatrix;
        }
    }
}
