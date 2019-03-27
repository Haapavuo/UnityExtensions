using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameObjectExtensions
{
    public static T SafeInstantiate<T>(this MonoBehaviour parent, GameObject prefab)
    {
        return SafeInstantiate<T>(prefab, parent.transform);
    }

    /// <summary>
    /// Creates an instance of the given prefab and returns the component T from the instance.
    /// If the given prefab is null, returns default T.
    /// </summary>
    public static T SafeInstantiate<T>(GameObject prefab)
    {
        if (prefab != null)
        {
            return Object.Instantiate(prefab).GetComponent<T>();
        }
        else
        {
            return default(T);
        }
    }

    public static T SafeInstantiate<T>(GameObject prefab, Transform parent)
    {
        if (prefab != null)
        {
            return Object.Instantiate(prefab, parent).GetComponent<T>();
        }
        else
        {
            return default(T);
        }
    }

    public static List<T> FindObjectsOfTypeAll<T>()
    {
        List<T> results = new List<T>();
        SceneManager.GetActiveScene().GetRootGameObjects().ToList().ForEach(g => results.AddRange(g.GetComponentsInChildren<T>()));
        return results;
    }

    public static T FindObjectOfTypeAll<T>() where T : MonoBehaviour
    {
        T result = null;
        SceneManager.GetActiveScene().GetRootGameObjects().ToList().Find(g => { result = g.GetComponentInChildren<T>(); return result != null; });
        return result;
    }

    public static void SetLayerRecursively(this GameObject obj, int newLayer)
    {
        if (obj == null)
        {
            return;
        }

        obj.layer = newLayer;

        foreach (Transform child in obj.transform)
        {
            if (child == null)
            {
                continue;
            }
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }
}
