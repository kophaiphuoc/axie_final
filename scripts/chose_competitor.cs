using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
public class chose_competitor : MonoBehaviour
{

    public SpriteRenderer src;
    public Sprite[] skins;
    public GameObject playerskin;
    public int a = 0;
    public static int skins_0;
    // Start is called before the first frame update


    private void Start()
    {
        AxieMixer.Unity.Mixer.Init();
    }

    public void Onselect(int a) {
        PlayerPrefs.SetInt("skins", a);
    }

    public void startgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
