using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float PlayerHealth = 100f;
    public bool player_is_dead = false;
    

    //void Start()
    //{

        
    //}
     void Update()
    {
        
       
        if (PlayerHealth<=0)
        {
            
            player_is_dead = true;
            FindObjectOfType<Game_Manager>().EndGame();
            Destroy(gameObject);


        }    
    }



}
