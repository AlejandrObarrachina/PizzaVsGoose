using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    private int xSpawnRange = 20;
    private int zSpawnRange = 20;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimals()
    {
        int animalsIndex = Random.Range(0, animalsPrefab.Length);
        Instantiate(animalsPrefab[animalsIndex], new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnRange), animalsPrefab[animalsIndex].transform.rotation);
    }
}
