using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoHard : MonoBehaviour
{

    // Use this for initialization
    public void OnClick()
    {
        SceneManager.LoadScene("HardMode");
    }

    // Update is called once per frame
    void Update()
    {

    }
}