using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_man : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chonCapDo()
    {
        SceneManager.LoadScene(2);
    }

    public void chonNhanVat()
    {
        SceneManager.LoadScene(1);
    }

    public void choi()
    {
        SceneManager.LoadScene(3);
    }
}
