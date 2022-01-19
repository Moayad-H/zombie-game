using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zombies_alive : MonoBehaviour
{
    TextMeshProUGUI zombies_left;
    Generate_enemy zombies_killed;
    Generate_enemy zombies_spawned;
    // Start is called before the first frame update
    void Start()
    {
        zombies_left = GetComponent<TMPro.TextMeshProUGUI>();
        zombies_killed = FindObjectOfType<Generate_enemy>();
        zombies_spawned = FindObjectOfType<Generate_enemy>();
    }

    // Update is called once per frame
    void Update()

    {
        int num;
        num = zombies_spawned.enemySpawnAmount - zombies_killed.enemiesKiled;
        zombies_left.text = "Zombies alive: " + num.ToString();
    }
}
