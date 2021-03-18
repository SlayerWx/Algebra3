using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;

public class MyTest : MonoBehaviour
{
    public Vector3 v1;
    public Vector3 v2;

    void Start()
    {
        Vec3 v3 = new Vec3(v1);
        Vec3 v4 = new Vec3(v2);
        Debug.Log("Vector3: " + Vector3.Cross(v1,v2));
        Debug.Log("Vec3: " + Vec3.Cross(v3, v4));
    }
}
