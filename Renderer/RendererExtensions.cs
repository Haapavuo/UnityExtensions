using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public static class RendererExtensions
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
	
    public static Tweener DOFade(this Renderer rend, float endValue, float duration)
    {
        if (rend == null)
        {
            Debug.LogWarning("Renderer was null.");
            return null;
        }

        if (rend is SpriteRenderer)
        {
            return SpriteRendererExtensions.DOFade((SpriteRenderer)rend, endValue, duration);
        }
        else if (rend is MeshRenderer)
        {
            var textMesh = rend.GetComponent<TextMesh>();
            if (textMesh != null)
            {
                return textMesh.DOFade(endValue, duration);
            }
            else
            {
                return ((MeshRenderer)rend).material.DOFade(endValue, duration);
            }
        }
        else
        {
            throw new Exception("Unsupported Renderer type: " + rend.GetType().FullName);
        }
    }
}
