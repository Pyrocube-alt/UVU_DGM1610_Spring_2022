using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    //public GameObject powerupPrefab;

    public int waveNumber = 1;

    private float spawnRange = 12;

    void Start()
    {
        SpawnEnemyWave(waveNumber);
        //SpawnPowerup(); 
    }

    void Update()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            //SpawnPowerup();
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    // void SpawnPowerup()
    // {
    //     Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    // }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);

        return randomPos;
    }
}
