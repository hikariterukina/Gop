using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

    public float mt = 66.00f;
    float tc;

    // Use this for initialization
    void Start()
    {
        tc = mt;
    }
        // Update is called once per frame
    void Update()
    {
        tc -= Time.deltaTime;
        GetComponent<Text>().text = ((float)tc).ToString("F2");
        if (tc > 60.01)
        {
            GetComponent<Text>().text = "";

        }
        if (tc < 0.01)
        {
            GetComponent<Text>().text = "Time's up!";
        }
        if (tc < -2)
        {
            SceneManager.LoadScene("Result");
        }
    }
}