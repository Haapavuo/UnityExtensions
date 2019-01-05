using UnityEngine;

namespace FAS.Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 Round(this Vector3 vec, float precision = 0.01f)
        {
            return new Vector3(Mathf.Round(vec.x / precision) * precision,
                Mathf.Round(vec.y / precision) * precision,
                Mathf.Round(vec.z / precision) * precision);
        }
    }
}
