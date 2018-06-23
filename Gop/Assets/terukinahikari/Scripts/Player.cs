﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text scoreText;

    // スコア
    public static int score;
    public static int ResultCount;
    // Use this for initialization
    void Start()
    {
        score = 0;
        ResultCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (Input.GetKey(KeyCode.W) )
        {
            ResultCount += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {

            ResultCount += 1;
        }
        if (Input.GetKeyDown(KeyCode.D) )
        {

            ResultCount += 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            ResultCount += 1;
        }
        if(score >= 7000)
        {
            SceneManager.LoadScene("Result");
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.W) && collision.gameObject.tag == "up" )
        {

                score += 500;
            
            Destroy(collision.gameObject);
            
            EffectInstance();
        }
        if (Input.GetKey(KeyCode.S)&& collision.gameObject.tag == "down"  )
        {
           
                score += 500;
           
            Destroy(collision.gameObject);

            EffectInstance();
        }
        if (Input.GetKeyDown(KeyCode.D) && collision.gameObject.tag == "right"  )
        {
           
                score += 500;
            
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKeyDown(KeyCode.A) && collision.gameObject.tag == "left")
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
