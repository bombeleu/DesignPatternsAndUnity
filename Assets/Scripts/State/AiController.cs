using UnityEngine;

public class AiController : MonoBehaviour {

	private IAiState _state;

    public IAiState State
    {
        get { return _state; }
        set
        {
            _state = value;
            _state.AiController = this;
        }
    }

    public AiController()
    {
        State = new AiStateIdle();
    }
}
