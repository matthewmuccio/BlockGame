using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Text highScoreText;

    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetFloat("highScore");
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void About()
    {
        Application.OpenURL("http://www.matthewmuccio.com");
    }

    public void Exit()
    {
        Application.Quit();
    }
}