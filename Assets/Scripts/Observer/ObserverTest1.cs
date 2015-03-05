using System;
using UnityEngine;

public class ObserverTest1 : MonoBehaviour
{
    public Action<string> OnCustomAction;

    private void Awake()
    {
        AddEventHandler(s => Debug.Log("First event handler: " + s));
        AddEventHandler(s => Debug.Log("Second event handler: " + s));
    }

    private void AddEventHandler(Action<string> action)
    {
        OnCustomAction += action;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (OnCustomAction != null)
                OnCustomAction("clicked");
        }

        if (Input.GetMouseButtonUp(1))
        {
            OnCustomAction = null;
        }
    }
}