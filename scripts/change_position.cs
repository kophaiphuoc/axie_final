using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_position : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject qua_bong, asset_trai, asset_phai;
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Score.score_benphai != Score.score_bentrai)
        {
            qua_bong.transform.position = new Vector2(0, 0);
        }
    }
}
