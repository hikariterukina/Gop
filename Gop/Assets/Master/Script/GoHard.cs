using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoHard : MonoBehaviour
{

    // Use this for initialization
    public void OnHard()
    {
        SceneManager.LoadScene(4);
    }

    public void OnEasy()
    {
        SceneManager.LoadScene(2);


    }
    public void OnNomal()
    {
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}