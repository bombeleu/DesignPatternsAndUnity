using UnityEngine;
using System.Collections;

public static class Extensions {

    public static GameObject Instantiate(this GameObject prefab)
    {
        return Object.Instantiate(prefab) as GameObject;
    }
}
