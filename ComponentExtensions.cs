using UnityEngine;

public static class ComponentExtensions
{
    public static void CopyComponentToIfExists<T>(this MonoBehaviour from, GameObject to) where T : Component
    {
        var component = from.GetComponent<T>();
        if (component != null)
        {
            component.CopyComponentTo(to);
        }
    }

    public static T CopyComponentTo<T>(this T original, GameObject destination) where T : Component
    {
        var type = original.GetType();
        var dst = destination.GetComponent(type) as T;
        if (!dst) dst = destination.AddComponent(type) as T;
        foreach (var field in type.GetFields())
        {
            if (field.IsStatic) continue;
            field.SetValue(dst, field.GetValue(original));
        }
        foreach (var prop in type.GetProperties())
        {
            if (!prop.CanWrite || !prop.CanWrite || prop.Name == "name") continue;
            prop.SetValue(dst, prop.GetValue(original, null), null);
        }
        return dst;
    }
}
