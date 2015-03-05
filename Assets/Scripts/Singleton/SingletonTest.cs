using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    public int SpawnAmount;
    public bool SpawnCompanionCube;
    public Transform SpawnPosition;

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var prefab = SpawnCompanionCube ? Prefabs.Instance.CompanionCube : Prefabs.Instance.Cube;

            for (var i = 0; i < SpawnAmount; ++i)
            {
                var go = prefab.Instantiate();
                go.transform.SetParent(SpawnPosition);
                go.transform.localPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-5f, 20f));
            }
        }
    }
}