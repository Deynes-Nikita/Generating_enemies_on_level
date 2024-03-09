using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _antPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay = 1f;
    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Create), _delay, _repeatRate);
    }

    private void Create()
    {
        int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
        float spawnAngleY = Random.Range(0, 360.0f);

        Instantiate(_antPrefab, _spawnPoints[spawnPointNumber].position, Quaternion.Euler(0, spawnAngleY, 0));
    }
}
