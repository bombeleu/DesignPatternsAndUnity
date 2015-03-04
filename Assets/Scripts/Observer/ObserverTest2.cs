using UnityEngine;

public class ObserverTest2 : MonoBehaviour {

    public delegate void CustomAction(string message);

    public event CustomAction OnCustomAction;

    void Awake()
    {
        AddEventHandler(s => Debug.Log("Third event handler: " + s));
        AddEventHandler(s => Debug.Log("Fourth event handler: " + s));
    }

    void AddEventHandler(CustomAction action)
    {
        OnCustomAction += action;
    }

    void Update()
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
