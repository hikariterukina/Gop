using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text scoreText;

    // スコア
    private int score;
    bool on;
    // Use this for initialization
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        on = true;
        if (Input.GetKey(KeyCode.W) && collision.gameObject.tag == "up" && on == true)
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKey(KeyCode.S)&& collision.gameObject.tag == "down" && on == true)
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKeyDown(KeyCode.D) && collision.gameObject.tag == "right" && on == true)
        {
            score += 500;
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKeyDown(KeyCode.A) && collision.gameObject.tag == "left" && on == true)
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
