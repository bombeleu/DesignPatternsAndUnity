using System.Collections.Generic;
using UnityEngine;

public class ClojureTest2 : MonoBehaviour 
{
    public static volatile IEnumerator<int> GetNewUid = GetNewUidClojure();

    private static IEnumerator<int> GetNewUidClojure()
    {
        var uid = 0;
        while(true) 
            yield return uid++;
    }
	
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Uid: " + GetNewUid.Current);
            GetNewUid.MoveNext();
        }
	}
}
