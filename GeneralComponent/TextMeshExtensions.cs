using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public static class TextMeshExtensions
{
    public static void SetAlpha(this TextMesh renderer, float alpha)
    {
        if (renderer == null) return;
        var c = renderer.color;
        c.a = alpha;
        renderer.color = c;
    }

    public static Tweener DOFade(this TextMesh mesh, float endValue, float duration)
    {
        return DOTween.ToAlpha(() => mesh.color, x => mesh.color = x, endValue, duration);
    }

    public static Tweener DOColor(this TextMesh mesh, Color endValue, float duration)
    {
        return DOTween.To(() => mesh.color, x => mesh.color = x, endValue, duration);
    }
}
