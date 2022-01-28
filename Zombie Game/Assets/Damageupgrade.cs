using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Damageupgrade : MonoBehaviour
{
    public GameObject damage_prompt;
    InfimaGames.LowPolyShooterPack.Character player_score;
    InfimaGames.LowPolyShooterPack.Character dmg;
    InfimaGames.LowPolyShooterPack.Character interact;
    public int dmg_bought = 0; 
    public bool dmg_interact = false;
    public bool max_reached;
    public GameObject dmg_max;
    private void Start()
    {
       dmg = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
       player_score = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
        interact = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{

        dmg_interact = true;
           damage_prompt.SetActive(true);
        if(max_reached==true)
        {
            dmg_max.SetActive(true);
        }
        //    Debug.Log("Purchase damage upgrade");
           
          
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        dmg_interact = false;
        damage_prompt.SetActive(false);
        dmg_max.SetActive(false);
    }
   
    public void dmgincrease() 

    {

        if (dmg_bought < 2)
        {
            if (player_score.score >= 1000f)
            {
                dmg_bought++;
                player_score.score -= 1000f;
                dmg.damage += 10f;
                Debug.Log("Damage has been upgraded");
            }
            else
            {
                Debug.Log("Not enough points");
            }
        }
        else
        {
            max_reached = true;
            damage_prompt.SetActive(true);
        }
       
    }
}
