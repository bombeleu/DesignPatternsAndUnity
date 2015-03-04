using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
    public GameObject Target;

    public void Update()
    {
        if(camera != null && Target != null)
            Camera.main.transform.LookAt(Target.transform);
    }
}