using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text scoreText;

    // スコア
    private int score;
    bool onu = true;
    bool ond = true;
    bool onr = true;
    bool onl = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (Input.GetKeyDown(KeyCode.W))
        {
            onu = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ond = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            onr = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            onl = false;
        }
        else
        {
            onu = true;
            ond = true;
            onr = true;
            onl = true;
        }
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (onu == false && collision.gameObject.tag == "up")
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();


        }
        if (ond == false && collision.gameObject.tag == "down")
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (onr == false && collision.gameObject.tag == "right")
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (onl == false && collision.gameObject.tag == "left")
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();
        }
    }
    void EffectInstance()
    {

    }
}
