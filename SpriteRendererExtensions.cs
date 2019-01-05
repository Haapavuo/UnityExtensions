using System;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public static class SpriteRendererExtensions
{
    public static void SetAlpha(this SpriteRenderer renderer, float alpha)
    {
        if (renderer == null) return;
        var c = renderer.color;
        c.a = alpha;
        renderer.color = c;
    }

    public static Tweener DOColor(this SpriteRenderer rend, Color endValue, float duration)
    {
        return DOTween.To(() => rend.color, x => rend.color = x, endValue, duration);
    }

    public static Tweener DOFade(this SpriteRenderer rend, float endValue, float duration)
    {
        return DOTween.ToAlpha(() => rend.color, x => rend.color = x, endValue, duration);
    }
}
