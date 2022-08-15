using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thanh_mana : MonoBehaviour
{
    public static float time_addmana;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time_addmana < 100)
        {
            time_addmana += Time.deltaTime * 20f;
            GetComponent<Slider>().value = time_addmana;
        }
        
    }
}
