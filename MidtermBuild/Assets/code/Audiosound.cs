using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiosound : MonoBehaviour
{
    public AudioClip selectcard;
    public AudioClip playcard;
    public AudioClip drawcard;
    public AudioClip yellowcard;
    public AudioClip lvlup;

    public static Audiosound instant;
    AudioSource m_source;
     void Start()
    {
        instant = this;    
    }
    void Awake()
    {
        m_source = GetComponent<AudioSource>();
    }
    public void selectcardd()
    {
        m_source.PlayOneShot(selectcard, m_source.volume);
    }
    public void playcardd()
    {
        m_source.PlayOneShot(playcard, m_source.volume);
    }

    public void drawcardd()
    {   
        m_source.PlayOneShot(drawcard, m_source.volume);
    }
    public void yellowcardd()
    {
        m_source.PlayOneShot(yellowcard, m_source.volume);
    }
    public void lvlupp()
    {
        m_source.PlayOneShot(lvlup, m_source.volume);
    }


}
