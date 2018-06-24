using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cokkie : MonoBehaviour {
    public bool rev;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!rev)
        {
            transform.Translate(-2, 0, 0);
            if (transform.position.x <= -2075 * 2)
            {
                Vector2 v = transform.position;
                v.x = 2075;
                transform.position = v;
            }
        }
        else
        {
            transform.Translate(2, 0, 0);
            if(transform.position.x >= 2075)
            {
                Vector2 v = transform.position;
                v.x = -2075;
                transform.position = v;
            }
        }
	}
}
