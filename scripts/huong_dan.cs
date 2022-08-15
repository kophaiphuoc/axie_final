using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class huong_dan : MonoBehaviour
{
    public GameObject huong_dan1;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void huongdan() {
        Debug.Log("onclick");
        //text.SetActive(true);
        huong_dan1.SetActive(true);
        //img2.SetActive(true);
    }
}
