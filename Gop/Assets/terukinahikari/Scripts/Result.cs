using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

    public Text ResultText;
    public GameObject ResultwinText;
    public GameObject ResultloseText;
    public GameObject Image1;
    public GameObject Image2;
    // Use this for initialization
    void Start () {
        if (Player.ResultCount >= 15)
        {
            Player.score -= Player.ResultCount -15 * 10;
        }
        if (Player.score >= 10000)
        {
            ResultwinText.SetActive(true);
            Image1.SetActive(true);
        }
        else
        {
            ResultloseText.SetActive(true);
            Image2.SetActive(true);
        }
        ResultText.text = Player.score.ToString();
    }
    public void Ontitle()
    {
        SceneManager.LoadScene(0);
    }
    public void OnSelect()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update () {
        

    }
}
