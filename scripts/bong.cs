using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bong : MonoBehaviour
{
    public GameObject ball;
    public bool ball_gravity ;
    float ball_y;
    public GameObject text_score_bentrai , text_score_benphai,
                        asset_trai, asset_phai;
    // Start is called before the first frame update
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ball_y = ball.transform.position.y;
        //Debug.Log(ball_gravity);
        if (ball_gravity)
        {
            body.gravityScale = -0.7f;
        }
        if (ball_y > -1.77) {
            body.gravityScale = 0.5f;
            ball_gravity = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "map" || collision.gameObject.tag == "cuc_da")
        {
            ball_gravity = true;
        }

        // khi bóng chạm vào khung thành bên trái
        if(collision.gameObject.tag == "khungthanh_trai")
        {
            Score.score_benphai += 1;
            text_score_benphai.GetComponent<Text>().text = Score.score_benphai  + "";
            transform.position = new Vector2(0, 0);
            asset_phai.transform.position = new Vector2(3.5f, 0);
            asset_phai.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
            asset_trai.transform.position = new Vector2(-3.5f, 0);
            asset_trai.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
        }

        // khi bóng chạm vào khung thành bên phải
        if (collision.gameObject.tag == "khungthanh_phai")
        {
            Score.score_bentrai += 1;
            text_score_bentrai.GetComponent<Text>().text = Score.score_bentrai + "";
            transform.position = new Vector2(0, 0);
            asset_phai.transform.position = new Vector2(3.5f, 0);
            asset_phai.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
            asset_trai.transform.position = new Vector2(-3.5f, 0);
            asset_trai.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
        }
    }
}
