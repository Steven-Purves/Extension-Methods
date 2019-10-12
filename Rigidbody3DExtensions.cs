using UnityEngine;

public static class Rigidbody3DExtensions 
{
    public static bool Freeze(this Rigidbody rigidbody)
    {
        if (rigidbody == null)
            return false;

        var zero = new Vector3(0, 0, 0);
        rigidbody.velocity = zero;
        rigidbody.angularVelocity = zero;
        rigidbody.isKinematic = true;
        return true;
    }
}
