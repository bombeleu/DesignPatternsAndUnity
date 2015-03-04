using UnityEngine;
using System.Collections;

public class Prefabs : MonoBehaviour {

    #region Singleton

    private static Prefabs _instance;
    public static Prefabs Instance
    {
        get
        {
            if (_instance == null)
            {
                return _instance = (Resources.Load("Prefabs", typeof(GameObject)) as GameObject).GetComponent<Prefabs>();
            }
            return _instance;
        }
    }

    #endregion

    public GameObject Cube;
    public GameObject CompanionCube;
}
