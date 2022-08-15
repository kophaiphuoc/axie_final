using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class chose_player : MonoBehaviour
{
    public SpriteRenderer src;
    public List<Sprite> skins_ = new List<Sprite>();
    private int selectskin = 0;
    public GameObject playerskin;
    public void next()
    {
        selectskin = selectskin + 1;
        if (selectskin == skins_.Count)
        {
            selectskin = 0;
        }
        src.sprite = skins_[selectskin];
    }

    public void back()
    {
        selectskin = selectskin - 1;
        if (selectskin < 0)
        {
            selectskin = skins_.Count - 1;
        }
        src.sprite = skins_[selectskin];
    }

    public void play()
    {
#if UNITY_EDITOR
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/selectedskin.prefab");
#endif
        SceneManager.LoadScene("Chon_doi_thu");
    }
}
