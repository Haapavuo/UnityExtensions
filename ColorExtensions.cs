using System;
using UnityEngine;
using UnityEngine.UI;

public static class ColorExtensions
{
    public static Color Copy(this Color c)
    {
        return new Color(c.r, c.g, c.b, c.a);
    }

    public static void SetAlpha(this Renderer renderer, float alpha)
    {
        if (renderer is SpriteRenderer)
        {
            ((SpriteRenderer)renderer).SetAlpha(alpha);
        }
        else if (renderer is MeshRenderer)
        {
            var textMesh = renderer.GetComponent<TextMesh>();
            if (textMesh != null)
            {
                textMesh.SetAlpha(alpha);
            }
            else
            {
                ((MeshRenderer)renderer).material.SetAlpha(alpha);
            }
        }
        else
        {
            throw new Exception("Unsupported Renderer type: " + renderer.GetType().FullName);
        }
    }

    public static void SetAlpha(this SpriteRenderer renderer, float alpha)
    {
        if (renderer == null) return;
        var c = renderer.color;
        c.a = alpha;
        renderer.color = c;
    }

    public static void SetAlpha(this TextMesh renderer, float alpha)
    {
        if (renderer == null) return;
        var c = renderer.color;
        c.a = alpha;
        renderer.color = c;
    }

    public static void SetAlpha(this Material material, float alpha)
    {
        if (material == null) return;
        var c = material.color;
        c.a = alpha;
        material.color = c;
    }

    public static void SetAlpha(this Image image, float alpha)
    {
        if (image == null) return;
        var c = image.color;
        c.a = alpha;
        image.color = c;
    }

    public static void SetAlpha(this RawImage image, float alpha)
    {
        if (image == null) return;
        var c = image.color;
        c.a = alpha;
        image.color = c;
    }

    public static void SetAlpha(this Text text, float alpha)
    {
        if (text == null) return;
        var c = text.color;
        c.a = alpha;
        text.color = c;
    }
}
