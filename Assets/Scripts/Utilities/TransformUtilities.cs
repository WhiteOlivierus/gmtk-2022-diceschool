using UnityEngine;

public static class TransformUtilities
{
    public static void SetParent(this Transform transform, string parentGOName)
    {
        if (parentGOName == null)
        {
            return;
        }
        GameObject parentGO = GameObject.Find(parentGOName);
        if (parentGO == null)
        {
            parentGO = new GameObject
            {
                name = parentGOName
            };
        }
        transform.parent = parentGO.transform;
    }
}