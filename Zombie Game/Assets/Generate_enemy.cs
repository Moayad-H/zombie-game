using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_enemy : MonoBehaviour
{
    public float waveNumber=0 ;
    public float enemySpawnwave=0 ;
    public float enemiesKiled ;
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public GameObject Skeleton;
    public GameObject special_audio;
    SpawnPoints spawner;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;


    // Start is called before the first frame update
    void Start()
    {
        
        //totalenemies = enemyAt1 + enemyAt2 + enemyAt3 + enemyAt4 + enemyAt5;
      //  spawner = FindObjectOfType<SpawnPoints>();
        //    StartCoroutine(EnemyDrop());
       // StartWave();
    }

   //private void Update()
    //{
    //    if (enemiesKiled >= enemyCount)
          //  NextWave();
  //  }

    public void EnemyDrop(GameObject enemy)
    { 
        Instantiate(enemy, Cube5.transform.position, Quaternion.identity);
        Instantiate(enemy, Cube4.transform.position, Quaternion.identity);
        Instantiate(enemy, Cube3.transform.position, Quaternion.identity);
        Instantiate(enemy, Cube2.transform.position, Quaternion.identity);
        Instantiate(enemy, Cube1.transform.position, Quaternion.identity);
        
       
    }
    public void StartWave()
    {
        waveNumber = 1;
        enemySpawnwave = 1;
        enemiesKiled = 0;
        enemyCount += 5;
        EnemyDrop(theEnemy);

        
    
    
    }
   public void NextWave()
    {
        
        waveNumber++;
        enemySpawnwave += 1;
        enemyCount += 5;
        if (waveNumber % 5 == 0)
        {
            for (int i = 0; i < enemySpawnwave; i++)
            {
                special_audio.SetActive(true);
                EnemyDrop(Skeleton);

            }
        }
        else
        {
            for (int i = 0; i < enemySpawnwave; i++)
            {
               EnemyDrop(theEnemy);
                special_audio.SetActive(false);

            }
        }
    }
   
}
