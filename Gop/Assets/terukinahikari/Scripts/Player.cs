using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        print(1);
        if(Input.GetKeyDown(KeyCode.Space) && collision.gameObject.tag == "CommandCube")
        {
            
            Destroy(collision.gameObject);
        }
    }
}
