using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_enemy : MonoBehaviour
{
    public int waveNumber = 0;
    public int enemySpawnAmount = 0;
    public int enemiesKiled = 0;
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public GameObject Skeleton;
    public GameObject special_audio;
    SpawnPoints spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<SpawnPoints>();
        //    StartCoroutine(EnemyDrop());
        StartWave();
    }
   
    //private void Update()
    //{
    //    if (enemiesKiled >= enemySpawnAmount)
    //        NextWave();
    //}
    private void StartWave()
    {
        waveNumber = 1;
        enemySpawnAmount = 1;
        enemiesKiled = 0;
        for (int i = 0; i < enemySpawnAmount; i++)
        {
            StartCoroutine(spawner.EnemyDrop(theEnemy));

        }
    
    
    }
    public void NextWave()
    {
        waveNumber++;
        if (enemySpawnAmount < 10)
        {
        //    Debug.Log("Spanw amount increased");
            enemySpawnAmount += 1;
        }
        if (waveNumber % 5 == 0)
        {
            for (int i = 0; i < enemySpawnAmount; i++)
            {
                special_audio.SetActive(true);
                StartCoroutine(spawner.EnemyDrop(Skeleton));

            }
        }
        else
        {
            for (int i = 0; i < enemySpawnAmount; i++)
            {
                StartCoroutine(spawner.EnemyDrop(theEnemy));

            }
        }
    }
   
}
