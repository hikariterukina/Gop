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
    public GameObject[] Effects;
    public AudioSource Good;
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
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            ResultCount += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            ResultCount += 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) )
        {

            ResultCount += 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            ResultCount += 1;
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.UpArrow) && collision.gameObject.tag == "up" )
        {
            score += 500;
            Good.Play();
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKey(KeyCode.DownArrow)&& collision.gameObject.tag == "down"  )
        {
            score += 500;
            Good.Play();
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && collision.gameObject.tag == "right"  )
        {
            score += 500;
            Good.Play();
            Destroy(collision.gameObject);
            EffectInstance();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && collision.gameObject.tag == "left")
        {
            score += 500;
            Good.Play();
            Destroy(collision.gameObject);
            EffectInstance();
        }
    }
    void EffectInstance()
    {
        int RandomR = Random.Range(0, 3);
         GameObject i=  Instantiate(Effects[RandomR], transform.position, Quaternion.identity);
        StartCoroutine(EffectDestroy(i));
    }
    IEnumerator EffectDestroy(GameObject efd)
    {
        yield return new WaitForSeconds(1f);
        Destroy(efd.gameObject);
    }
}
