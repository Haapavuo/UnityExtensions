using System;
using UnityEngine;
using UnityEngine.UI;

public static class ImageExtensions
{
    public static void SetAlpha(this Image image, float alpha)
    {
        if (image == null) return;
        var c = image.color;
        c.a = alpha;
        image.color = c;
    }
}
