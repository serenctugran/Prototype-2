using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnManager : MonoBehaviour
{
    public GameObject[] newAnimalPrefab;
    private float spawnRangeZ = 17.0f;

    private void Start()
    {
        InvokeRepeating("AnimalRandomSpawnZ", 1, 2.1f);
    }
    void AnimalRandomSpawnZ()
    {
        int animalIndexZ = Random.Range(0, 3);
        Vector3 spawnPosZ = new Vector3( spawnRangeZ, 0, Random.Range(16.0f, -1.0f));
        Instantiate(newAnimalPrefab[animalIndexZ], spawnPosZ, newAnimalPrefab[animalIndexZ].transform.rotation);
    }
}
