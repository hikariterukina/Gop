using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public float cubespeed =  1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 pos = transform.position;
        pos.x += cubespeed * Time.deltaTime;
        transform.position = pos;
        if(this.transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
        
		
	}
    
}
