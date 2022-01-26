using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WaveNumber : MonoBehaviour
{
    TextMeshProUGUI round_text;
    Generate_enemy current_round;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        round_text = GetComponent<TextMeshProUGUI>();
        //current_round = FindObjectOfType<Generate_enemy>();
        current_round = manager.GetComponent<Generate_enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        round_text.text = "Round: " + current_round.waveNumber.ToString();
    }
}
