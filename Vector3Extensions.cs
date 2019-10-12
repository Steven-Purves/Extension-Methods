using UnityEngine;

public static class Vector3Extensions 
{
    // Vector3 With 
    public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }
    // Flat return Y = 0
    public static Vector3 Flat(this Vector3 original)
    {
        return new Vector3(original.x, 0, original.z);
    }
    // DirectionTo
    public static Vector3 DirectionAwayFrom (this Vector3 original, Vector3 destination)
    {
        return Vector3.Normalize(original - destination);
    }
    public static Vector3 DirectionTo(this Vector3 original, Vector3 destination)
    {
        return Vector3.Normalize(destination - original);
    }
    public static Vector3 SpinOnAxis(this Vector3 original, float speed, float? x = null, float? y = null, float? z = null)
    {
        x = x != null ? Time.deltaTime * speed: x;
        y = y != null ? Time.deltaTime * speed : y;
        z = z != null ? Time.deltaTime * speed : z;
        return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }
}
