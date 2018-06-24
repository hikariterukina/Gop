using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

    public float mt = 60.00f;
    float tc;
    public GameObject Timetext;
    public GameObject Finishtext;


    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        tc = mt;
    }
        // Update is called once per frame
    void Update()
    {
        tc -= Time.deltaTime;
        Timetext.GetComponent<Text>().text = ((float)tc).ToString("F2");
        if (tc > 60.01)
        {
            GetComponent<Text>().text = "";

        }
        if (tc < 0.2)
        {

            Time.timeScale = 0;

            Finishtext.SetActive(true);

            SceneManager.LoadScene(5);
        }
    }
}