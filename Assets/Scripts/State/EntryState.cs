using UnityEngine;

public class EntryState : IState {
    
    public void Execute()
    {
        Debug.Log("excecuting state");
    }
}