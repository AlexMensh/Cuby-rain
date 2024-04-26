using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private float spawnRadius = 5f;
    [SerializeField] private Cube _cubePrefab;

    public void SpawnCube()
    {
        Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;

        Instantiate(_cubePrefab, spawnPosition, Quaternion.identity);
    }
}