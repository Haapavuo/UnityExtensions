using System;
using UnityEngine;
using UnityEngine.UI;

public static class ColorExtensions
{
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
}
