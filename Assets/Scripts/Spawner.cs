using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint _spawnPoint;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private int _cubesAmount;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(_spawnDelay);

        for (int i = 0; i < _cubesAmount; i++)
        {
            _spawnPoint.SpawnCube();

            yield return wait;
        }
    }
}