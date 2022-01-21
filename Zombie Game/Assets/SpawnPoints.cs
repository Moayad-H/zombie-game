using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    // Start is called before the first frame update
    Generate_enemy count;
    public IEnumerator EnemyDrop(GameObject enemy)
    {


        //zPos = Random.Range(-12, 1);
        //xPos = Random.Range(-12, 20);
        Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
        count.enemyCount++;
    }
}
