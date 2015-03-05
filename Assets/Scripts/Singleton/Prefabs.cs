using UnityEngine;

public class Prefabs : MonoBehaviour
{
    public GameObject CompanionCube;
    public GameObject Cube;

    #region Singleton

    private static Prefabs _instance;

    public static Prefabs Instance
    {
        get
        {
            if (_instance == null)
            {
                return
                    _instance = (Resources.Load("Prefabs", typeof (GameObject)) as GameObject).GetComponent<Prefabs>();
            }
            return _instance;
        }
    }

    #endregion
}