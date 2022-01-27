using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Information : MonoBehaviour
{
    public GameObject earth_prompt;
    public GameObject player_ui;
    InfimaGames.LowPolyShooterPack.Character player_score;
    InfimaGames.LowPolyShooterPack.Character interact;
    public bool earth_interact = false;
    public bool f = false;
    // Start is called before the first frame update
    void Start()
    {
       
        interact = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{

        earth_interact = true;
       

        //}
    }
    private void OnTriggerExit(Collider other)
    {
        
        earth_interact = false;
        earth_prompt.SetActive(false);
        player_ui.SetActive(true);
    }
    public void Show_UI()
    {

        earth_prompt.SetActive(true);
        player_ui.SetActive(false);
    }
    public void Close_UI()
    {
        earth_prompt.SetActive(false);
        player_ui.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
