using System;
using UnityEngine;

public class ClojureTest : MonoBehaviour
{
    public static volatile Func<int> GetNewUid = GetNewUidClojure();

    private static Func<int> GetNewUidClojure()
    {
        var uid = 0;
        return () => uid++;
    }

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Uid: " + GetNewUid());
        }
    }
}