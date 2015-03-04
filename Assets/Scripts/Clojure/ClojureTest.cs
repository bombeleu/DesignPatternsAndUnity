using UnityEngine;
using System.Collections;
using System;

public class ClojureTest : MonoBehaviour {

    static Func<int> GetNewUidClojure()
    {
        int uid = 0;
        return () => uid++;
    }

    public Func<int> GetNewUid = GetNewUidClojure();

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Uid: " + GetNewUid());
        }
    }
}
