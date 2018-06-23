using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public float cubespeed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -=   transform.right * cubespeed * Time.deltaTime;
        if(this.transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
        
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this);
        }
    }
}
