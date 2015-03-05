using UnityEngine;

public class ObserverTest3 : MonoBehaviour
{
    private void Start()
    {
        GetComponent<ObserverTest1>().OnCustomAction("injected broadcast");
        GetComponent<ObserverTest1>().OnCustomAction = s => Debug.Log("Fifth event handler: " + s);

        GetComponent<ObserverTest2>().OnCustomAction += s => Debug.Log("Sixth event handler: " + s);
        // compile error: 
        // 1) broadcasting to other subscriber
        // GetComponent<ObserverTest2>().OnCustomAction("injected broadcast");
        // 2) removing /overriding other subscriber
        // GetComponent<ObserverTest2>().OnCustomAction = (s) => Debug.Log("Third event handler: " + s);
    }
}