using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute_mp3 : MonoBehaviour
{
   
    public AudioSource m_audio;
    public AudioSource mouse_mp3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Mouse0) )
        {
    
            Debug.Log("1");
            mouse_mp3.Play();
            m_audio.Pause();
        }
         else if (Input.GetKey(KeyCode.Mouse1)) {

            Debug.Log("2");
            mouse_mp3.Play();
            m_audio.Play();
            
        }
        //if (Input.GetKey(KeyCode.Mouse0) && of == false)
        //{
          
        //    Debug.Log("2");
        //    mouse_mp3.Play();
        //    m_audio.Play();
        //    of = true;
        //}
    }
     public void onclick() {
        

    }
}
