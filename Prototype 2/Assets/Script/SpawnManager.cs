using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;

    private float spawnRangeX = 20.0f;
    private float spawnRangeZ = 20.0f;
    private float startDelay = 2;
    private float spawnInternal = 1.5f;
    void Start()
    {
        InvokeRepeating("AnimalRandomSpawn", startDelay, spawnInternal);

       
    }
    void Update()
    {
       
    }
    void AnimalRandomSpawn()
    {
        int animalIndex = Random.Range(0, 3);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
    
}
