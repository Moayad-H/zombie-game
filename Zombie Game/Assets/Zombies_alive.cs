using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Zombies_alive : MonoBehaviour
{
    public GameObject manager;
    TextMeshProUGUI zombies_left;
    Generate_enemy zombies_killed;
    Generate_enemy zombies_spawned;
    private float num;
    // Start is called before the first frame update
    void Start()
    {
       
        zombies_left = GetComponent<TextMeshProUGUI>();
        zombies_killed = manager.GetComponent<Generate_enemy>();
        zombies_spawned = manager.GetComponent<Generate_enemy>();
    }

    // Update is called once per frame
    void Update()

    {
        
        num = zombies_spawned.enemyCount - zombies_killed.enemiesKiled;
        zombies_left.text = "Zombies alive: " + num.ToString();
    }
}
