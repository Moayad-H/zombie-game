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
    
    public bool dmg_interact = false;
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

           damage_prompt.SetActive(true);
        //    Debug.Log("Purchase damage upgrade");
           if (interact.interacting == true)
            {
               dmgincrease();
          }
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        dmg_interact = false;
        damage_prompt.SetActive(false);
    }
   
    public void dmgincrease() 

    {
        
            if (player_score.score >= 1000f)
            {
                player_score.score -= 1000f;
                dmg.damage += 10f;
                Debug.Log("Damage has been upgraded");
            }
            else
            {
                Debug.Log("Not enough points");
            }
        
       
    }
}
