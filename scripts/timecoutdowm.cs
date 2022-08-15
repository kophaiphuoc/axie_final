using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timecoutdowm : MonoBehaviour
{
    public Text txttime;
    public float timeleft;
    public bool timeon = false;
    
    // Start is called before the first frame update
    void Start()
    {
        timeon = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeon) {
            if (timeleft > 0)
            {
                timeleft -= Time.deltaTime;
                updatetime(timeleft);
            }
            else
            {
                timeleft = 0;
                timeon = false;
            
            }
        }
    }
    void updatetime(float curenttime) {
        curenttime += 1;

        //float minutes = Mathf.FloorToInt(curenttime / 60);
        float seconds = Mathf.FloorToInt(curenttime % 120);

        txttime.text = string.Format("{00:00}",seconds);
    }
}
