public static class UnityObjectExtensions
{
    /// <summary>
    /// Returns a reference to the Unity Object or null if the object is "fake null" or null.
    /// By using this, the null conditional operator can be safely used as follows: obj.Ref()?.transform;
    /// </summary>
    /// <typeparam name="T">Type of the object instance.</typeparam>
    /// <param name="o">The object instance.</param>
    /// <returns>Null or the object instance reference.</returns>
    public static T Ref<T>(this T o) where T : UnityEngine.Object
    {
        // May look like nothing but Unity has overridden the == operator
        return o == null ? null : o;
    }
}
