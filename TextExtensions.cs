using System;
using UnityEngine;
using UnityEngine.UI;

public static class TextExtensions
{
    public static void SetAlpha(this Text text, float alpha)
    {
        if (text == null) return;
        var c = text.color;
        c.a = alpha;
        text.color = c;
    }
}
