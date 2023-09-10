using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawRangeX = 20f;
    private float spawnRangeZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    public int score, lives;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        Debug.Log("Lives = 3");
        Debug.Log("Score = 0");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // spawn random animals at random position on the x axis
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawRangeX, spawRangeX), 0, spawnRangeZ);
        Vector3 positiveZSpawnPos = new Vector3(spawRangeX, 0, Random.Range(2, 15));
        Vector3 negatitiveZSpawnPos = new Vector3(-spawRangeX, 0, Random.Range(2, 15));
        int animalIndex;
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], positiveZSpawnPos, Quaternion.Euler(0f, -90f, 0f));
        Instantiate(animalPrefabs[animalIndex], negatitiveZSpawnPos, Quaternion.Euler(0f, 90f, 0f));
    }
}
