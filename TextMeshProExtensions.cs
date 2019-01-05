using DG.Tweening;
using TMPro;

public static class TextMeshProExtensions
{
    public static Tweener DOFade(this TextMeshProUGUI text, float endValue, float duration)
    {
        return DOTween.ToAlpha(() => text.color, x => text.color = x, endValue, duration);
    }

    public static void SetAlpha(this TextMeshProUGUI text, float alpha)
    {
        var c = text.color;
        c.a = alpha;
        text.color = c;
    }
}
