using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moce_player2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider thanh_mana;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(3f, 3f, 3f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-3f, 3f, 3f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * 5, 0);
            //transform.localScale = new Vector3(3f, 3f, 3f);
        }
    }
}
