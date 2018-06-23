using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {
    public GameObject CommandCubeU;
    public GameObject CommandCubeD;
    public GameObject CommandCubeR;
    public GameObject CommandCubeL;

    private int waitcount = 0;                                                     


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        waitcount += 1;
        int rcount = Random.Range(0, 4);
        if (rcount == 0 && waitcount % 80  == 0)
        {
            Instantiate(CommandCubeU, transform.position, Quaternion.Euler(0, 0, -90));
        }
        if (rcount == 1 && waitcount % 80 == 0)
        {
            Instantiate(CommandCubeD, transform.position, Quaternion.Euler(0, 0, 90));
        }
        if (rcount == 2 && waitcount % 80 == 0)
        {
            Instantiate(CommandCubeR, transform.position, Quaternion.Euler(90, 0, 0 ));
        }
        if (rcount == 3 && waitcount % 80 == 0)
        {
            Instantiate(CommandCubeL, transform.position, Quaternion.Euler(0, 0, 0));
        }
    }
}
