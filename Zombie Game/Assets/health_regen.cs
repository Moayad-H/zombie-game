using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_regen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject health_prompt;
    InfimaGames.LowPolyShooterPack.Character player_score;
    InfimaGames.LowPolyShooterPack.Character dmg;
    InfimaGames.LowPolyShooterPack.Character interact;
   // public int dmg_bought = 0;
    public bool health_interact = false;
    public bool max_reached;
   // public GameObject dmg_max;
    Health Player_hp;
    private void Start()
    {
        dmg = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
        player_score = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
        interact = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
        Player_hp = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{

        health_interact = true;
        health_prompt.SetActive(true);
        //if (max_reached == true)
      //  {
       //     dmg_max.SetActive(true);
       // }
        //    Debug.Log("Purchase damage upgrade");


        //}
    }
    private void OnTriggerExit(Collider other)
    {
        health_interact = false;
        health_prompt.SetActive(false);
       // dmg_max.SetActive(false);
    }

    public void health_increase()

    {

        if (Player_hp.PlayerHealth < 100)
        {
            if (player_score.score >= 1000f)
            {
                Player_hp.PlayerHealth = 100f;
                player_score.score -= 1000f;

                Debug.Log("Health restored");
            }
            else
            {
                Debug.Log("Not enough points");
            }
        }
        else
        {

            health_prompt.SetActive(true);
        }

    }
    }
