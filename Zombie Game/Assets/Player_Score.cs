using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_Score : MonoBehaviour
{
    TextMeshProUGUI score_text;
    InfimaGames.LowPolyShooterPack.Character player_score;
    
    // Start is called before the first frame update
    void Start()
    {
        score_text = GetComponent<TMPro.TextMeshProUGUI>();
        player_score = FindObjectOfType<InfimaGames.LowPolyShooterPack.Character>();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = player_score.score.ToString();
    }
}
