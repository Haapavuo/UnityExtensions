using System;
using UnityEngine;
using UnityEngine.UI;

public static class RawImageExtensions
{
    public static void SetAlpha(this RawImage image, float alpha)
    {
        if (image == null) return;
        var c = image.color;
        c.a = alpha;
        image.color = c;
    }
}
