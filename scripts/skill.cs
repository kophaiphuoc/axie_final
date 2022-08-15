using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 100);
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * 20, 0, 0);
    }
}
