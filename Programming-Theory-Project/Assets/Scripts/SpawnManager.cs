using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] starPrefabs;
    private float xSpawnPos = 9.0f;
    private float ySpawnPos = 12.0f;
    private float zSpawnPos = 0f;

    void Awake()
    {
        InvokeRepeating("SpawnStars", 3.0f, 2.0f);
    }

    // ABSTRACTION
    void SpawnStars()
    {
        int index = 0;
        float randomXpos = Random.Range(-xSpawnPos, xSpawnPos);
        Vector3 spawnPos = new Vector3(randomXpos, ySpawnPos, zSpawnPos);

        Instantiate(starPrefabs[index], spawnPos, starPrefabs[index].transform.rotation);
    }
}
