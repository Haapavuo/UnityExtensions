using System.Collections.Generic;

public static class ListExtensions
{
    public static void AddTimes<T>(this List<T> list, T element, int times)
    {
        for (int i = 0; i < times; i++)
        {
            list.Add(element);
        }
    }
}
