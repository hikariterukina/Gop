using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {
    public GameObject CommandCubeU;
    public GameObject CommandCubeD;
    public GameObject CommandCubeR;
    public GameObject CommandCubeL;
    private int Span = 90;
    public static int Tcount;

    private int waitcount = 0;                                                     


	// Use this for initialization
	void Start () {
        waitcount = 0;
        Tcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        waitcount += 1;
        Tcount += 1;
        int rcount = Random.Range(0, 4);
        if (rcount == 0 && waitcount % Span  == 0)
        {
            Instantiate(CommandCubeU, transform.position, Quaternion.Euler(0, 0, -90));
        }
        if (rcount == 1 && waitcount % Span == 0)
        {
            Instantiate(CommandCubeD, transform.position, Quaternion.Euler(0, 0, 90));
        }
        if (rcount == 2 && waitcount % Span == 0)
        {
            Instantiate(CommandCubeR, transform.position, Quaternion.Euler(0, 180, 0 ));
        }
        if (rcount == 3 && waitcount % Span == 0)
        {
            Instantiate(CommandCubeL, transform.position, Quaternion.Euler(0, 0, 0));
        }
        if(Tcount == 300)
        {
            Span -= 10;
            Tcount = 0;
            CubeScript.cubespeed += -100;
        }
        if(CubeScript.cubespeed <= -600)
        {
            CubeScript.cubespeed = -200;
        }
        if(Span <= 30)
        {
            Span = 90;
        }
    }
}
