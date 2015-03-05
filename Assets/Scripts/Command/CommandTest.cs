using UnityEngine;

public class CommandTest : MonoBehaviour {

    private Invoker _invoker;

	void Start () {
        var receiver = new Receiver();
        var command = new ConcreteCommand(receiver);
	    _invoker = new Invoker {Command = command};
	}

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _invoker.ExecuteCommand();
        }
    }
}
