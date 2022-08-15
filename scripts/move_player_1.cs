using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_player_1 : MonoBehaviour
{
    // Start is called before the first frame update
    bool isNen_dat;
    public GameObject skill;
    public Sprite[] skins;
    public SpriteRenderer src;
    private int skinindex;
    public Game.AxieFigure figure;
    void Start()
    {
        skinindex = PlayerPrefs.GetInt("skins",0);
        //src.sprite = skins[skinindex];
        string genes = "0x2000000000000300008100e08308000000010010088081040001000010a043020000009008004106000100100860c40200010000084081060001001410a04406";
        figure.SetGenes("", genes);
        var meshRenderer = figure.GetComponent<MeshRenderer>();
        meshRenderer.sortingOrder = 10;
        figure.transform.localScale = Vector3.one * 4;
        //src.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-0.4798764f, 0.4454139f, 1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(0.4798764f, 0.4454139f, 1f); 
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            figure.DoJumpAnim();
            if (isNen_dat)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
                isNen_dat = false;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            figure.DoAttackMeleeAnim();
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log(thanh_mana.time_addmana);

            if (thanh_mana.time_addmana >= 100)
            {
                Instantiate(skill, new Vector2(transform.localPosition.x, transform.localPosition.y + 1), transform.localRotation);
                thanh_mana.time_addmana = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "map" || collision.gameObject.tag == "cuc_da")
        {
            isNen_dat = true;
        }
    }

}

