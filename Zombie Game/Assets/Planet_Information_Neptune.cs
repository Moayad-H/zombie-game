using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Information_Neptune : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planet_prompt;
    public GameObject player_ui;
    InfimaGames.LowPolyShooterPack.Character player_score;
    InfimaGames.LowPolyShooterPack.Character interact;
    public bool planet_interact = false;
    public bool f = false;
    public GameObject ui_prompt;
    // Start is called before the first frame update
    void Start()
    {

        interact = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{

        planet_interact = true;
        ui_prompt.SetActive(true);

        //}
    }
    private void OnTriggerExit(Collider other)
    {

        planet_interact = false;
        planet_prompt.SetActive(false);
        player_ui.SetActive(true);
        ui_prompt.SetActive(false);
    }
    public void Show_UI()
    {

        planet_prompt.SetActive(true);
        player_ui.SetActive(false);
    }
    public void Close_UI()
    {
        planet_prompt.SetActive(false);
        player_ui.SetActive(true);
    }
}
