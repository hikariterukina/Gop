using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {


   
    public static float cubespeed =  -200;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 pos = transform.position;
        pos.x += cubespeed * 4 * Time.deltaTime;
        transform.position = pos;

        if(this.transform.position.x <= -1000)
        {
            if (Player.score <= 0)
            {
                Player.score = 0;
            }
            else
            {
                Player.score -= 500;
            }
            Destroy(gameObject);
        }
        
		
	}
    
}
