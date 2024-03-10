using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Ant _antPrefab;

    public void CreatePrefab()
    {
        float spawnAngleY = Random.Range(0, 360.0f);

        Instantiate(_antPrefab, transform.position, Quaternion.Euler(0, spawnAngleY, 0));
    }
}
