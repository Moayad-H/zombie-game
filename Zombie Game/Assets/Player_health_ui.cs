using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player_health_ui : MonoBehaviour
{
    TextMeshProUGUI health_text;
    Health current_health;
    // Start is called before the first frame update
    void Start()
    {
        health_text = GetComponent<TMPro.TextMeshProUGUI>();
        current_health = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        health_text.text = current_health.PlayerHealth.ToString();

    }
}
