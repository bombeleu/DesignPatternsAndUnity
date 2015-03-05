using UnityEngine;

public class IdleState : IState {

    public void Execute()
    {
        Debug.Log("idling");
    }
}
