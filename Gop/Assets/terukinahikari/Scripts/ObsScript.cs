using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsScript : MonoBehaviour {

    private float ObsSpeed = 50;
    private int speedcount;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 8.0f);
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        speedcount = Random.Range(-4, 4);
        Vector2 pos = transform.position;
        pos.x -= speedcount *7* ObsSpeed * Time.deltaTime;
        pos.y += ObsSpeed * Time.deltaTime;
        transform.position = pos;
		
	}
}
