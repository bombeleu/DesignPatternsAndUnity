using UnityEngine;

public class StateTest : MonoBehaviour
{
    public IState State { get; set; }

    void Start()
    {
        State = new EntryState();
    }

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            State.Execute();
        }

        if (Input.GetMouseButtonUp(1))
        {
            State = new IdleState();
        }
    }
}