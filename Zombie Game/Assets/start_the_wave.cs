using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_the_wave : MonoBehaviour
{
    Generate_enemy start;
    public GameObject round_start;
    // Start is called be
    // fore the first frame update
    public int start_count = 0;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        start = FindObjectOfType<Generate_enemy>();
        if(start_count==0)
        {
            start.StartWave();
            round_start.SetActive(true);
            start_count++;
        }
        
    }
}
