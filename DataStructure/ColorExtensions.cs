using System;
using UnityEngine;
using UnityEngine.UI;

public static class ColorExtensions
{
    public static Color Copy(this Color c)
    {
        return new Color(c.r, c.g, c.b, c.a);
    }
}
