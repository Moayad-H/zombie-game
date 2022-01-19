using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_music : MonoBehaviour
{
   public AudioSource m_MyAudioSource;


    public bool m_Play;
    
    void Start()
    {
       
        m_MyAudioSource = GetComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Play == true)
            m_MyAudioSource.Play();
        
    }
}
