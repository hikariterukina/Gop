using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
            Destroy(collision.gameObject);
        }
        if (ond == false && collision.gameObject.tag == "down")
        {
            Destroy(collision.gameObject);
        }
        if (onr == false && collision.gameObject.tag == "right")
        {
            Destroy(collision.gameObject);
        }
        if (onl == false && collision.gameObject.tag == "left")
        {
            Destroy(collision.gameObject);
        }
    }
}
