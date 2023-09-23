using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundPrefab;
    public float spawnInterval = 5f;

    private float nextSpawnTime;

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnGround();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnGround()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.y = Random.Range(-1f, 1f); // Randomize vertical position within a range
        Instantiate(groundPrefab, spawnPosition, Quaternion.identity);
    }
}

