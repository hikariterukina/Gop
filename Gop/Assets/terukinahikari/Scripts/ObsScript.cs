using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsScript : MonoBehaviour {

    private float ObsSpeed = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * ObsSpeed * Time.deltaTime;
		
	}
}
