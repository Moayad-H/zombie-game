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

    // Start is called before the first frame update
    void Start()
    {
        //    StartCoroutine(EnemyDrop());
        StartWave();
    }
    IEnumerator EnemyDrop(GameObject enemy)
    {
        
        
            zPos = Random.Range(-12, 1);
            xPos = Random.Range(-12, 20);
            Instantiate(enemy, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            enemyCount++;
    }
    //private void Update()
    //{
    //    if (enemiesKiled >= enemySpawnAmount)
    //        NextWave();
    //}
    private void StartWave()
    {
        waveNumber = 1;
        enemySpawnAmount = 5;
        enemiesKiled = 0;
        for (int i = 0; i < enemySpawnAmount; i++)
        {
            StartCoroutine(EnemyDrop(theEnemy));

        }
    
    
    }
    public void NextWave()
    {
        waveNumber++;
        if (enemySpawnAmount < 50)
        {
        //    Debug.Log("Spanw amount increased");
            enemySpawnAmount += 2;
        }
        if (waveNumber % 5 == 0)
        {
            for (int i = 0; i < enemySpawnAmount; i++)
            {
                special_audio.SetActive(true);
                StartCoroutine(EnemyDrop(Skeleton));

            }
        }
        else
        {
            for (int i = 0; i < enemySpawnAmount; i++)
            {
                StartCoroutine(EnemyDrop(theEnemy));

            }
        }
    }
   
}
