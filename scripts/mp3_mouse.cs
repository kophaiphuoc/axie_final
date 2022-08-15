using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mp3_mouse : MonoBehaviour
{
    public AudioSource m_audio;
    public AudioSource mouse_mp3;
    // Start is called before the first frame update
    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
