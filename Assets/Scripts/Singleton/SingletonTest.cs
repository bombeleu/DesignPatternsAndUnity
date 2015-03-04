using UnityEngine;
using System.Collections;

public class SingletonTest : MonoBehaviour {

    public bool SpawnCompanionCube;
    public Transform SpawnPosition;
    public int SpawnAmount;

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var prefab = SpawnCompanionCube ? Prefabs.Instance.CompanionCube : Prefabs.Instance.Cube;

            for (int i = 0; i < SpawnAmount; ++i)
            {
                var go = prefab.Instantiate();
                go.transform.SetParent(SpawnPosition);
                go.transform.localPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-5f, 20f));
            }
        }
    }
}
