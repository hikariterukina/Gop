using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

    public Text ResultText;
    public GameObject Image1;
    public GameObject Image2;
    // Use this for initialization
    void Start () {
        if (Player.ResultCount >= 15)
        {
            Player.score -= Player.ResultCount -15 * 5;
        }
        if (Player.score >= 7000)
        {
            Image1.SetActive(true);
        }
        else
        {
            Image2.SetActive(true);
        }
        ResultText.text = Player.score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        

    }
}
