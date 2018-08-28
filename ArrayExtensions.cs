using System;
public static class ArrayExtensions
{
    public static void ForEach<T>(this T[] array, Action<T> a)
    {
        foreach (var i in array)
        {
            a(i);
        }
    }
}
