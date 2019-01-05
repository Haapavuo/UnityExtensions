using System;
using UnityEngine;
using UnityEngine.UI;

public static class MaterialExtensions
{
    public static void SetAlpha(this Material material, float alpha)
    {
        if (material == null) return;
        var c = material.color;
        c.a = alpha;
        material.color = c;
    }
}
