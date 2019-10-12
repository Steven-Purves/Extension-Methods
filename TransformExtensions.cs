using UnityEngine;
using System.Linq;

public static class TransformExtensions 
{
    public static Vector3 DirectionTo(this Transform original, Transform destination)
    {
        return original.position.DirectionTo(destination.position);
    }
    public static Vector3 DirectionAwayFrom(this Transform original, Transform destination)
    {
        return original.position.DirectionAwayFrom(destination.position);
    }
    public static Transform[] GetChildren(this Transform parent)
    {
        Transform[] allChildTransforms = parent.Cast<Transform>().ToArray();

        return allChildTransforms;
    }
}
