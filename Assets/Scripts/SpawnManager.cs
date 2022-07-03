using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float spawnRangeX = 20.0f;
    public float spawnPosZ = 20.0f;

    public float spawnRangeZ = 10.0f;
    public float spawnPozX = 20.0f;
    
    public float startDelay = 2.0f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        int axis = Random.Range(0, 2);
        Vector3 spawnPos;
        Quaternion rotation = animalPrefab[animalIndex].transform.rotation;
        if (axis == 0)
        {
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        }
        else
        {
            axis = Random.Range(0, 2);
            if (axis == 0)
            {
                spawnPos = new Vector3(spawnPozX, 0, Random.Range(0, spawnRangeZ));
                rotation = rotation * Quaternion.AngleAxis(90, Vector3.up);
            }
            else
            {
                spawnPos = new Vector3(-spawnPozX, 0, Random.Range(0, spawnRangeZ));
                rotation = rotation * Quaternion.AngleAxis(-90, Vector3.up);
            }
        }
        Instantiate(animalPrefab[animalIndex], spawnPos, rotation);
    }
}
