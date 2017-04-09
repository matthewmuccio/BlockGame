using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Text highScoreText;

    void Start()
    {
        highScoreText.text = "High Score: " + ((int)PlayerPrefs.GetFloat("highScore"));
    }

    void Update()
    {

    }

    public void Play()
    {
        StartCoroutine(loading());
    }

    IEnumerator loading()
    {
        yield return new WaitForSeconds(1F);
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