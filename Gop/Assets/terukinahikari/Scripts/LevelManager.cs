using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject[] obs;
    private int Obscount;
    private int Obsrd;
    private int ObsTcount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Obscount = Random.Range(1, obs.Length);
        Obsrd = Random.Range(30, 70);
        ObsTcount += 1;
        if(ObsTcount == 400)
        {
            Instantiate(obs[Obscount], transform.position, Quaternion.Euler(Obsrd, 0, 0));
            ObsTcount = 0;
        }

	}
}
