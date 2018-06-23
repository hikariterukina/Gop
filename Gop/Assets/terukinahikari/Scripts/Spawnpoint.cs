using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {
    public GameObject CommandCube;
    private int waitcount = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        waitcount += 1;
        if (waitcount % 12 == 0)
        {
            Instantiate(CommandCube, transform.position, transform.rotation);
        }
    }
}
