using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    // Refers to the Text object that displays the player's most recent score.
    public Text lastScoreText;
    // Refers to the Text object that displays the player's current high score.
    public Text highScoreText;

    // Use this for initialization
    void Start()
    {
        lastScoreText.text = "" + (int)PlayerPrefs.GetFloat("lastScore");
        highScoreText.text = "High Score: " + ((int)PlayerPrefs.GetFloat("highScore"));
    }

    // Runs when the player clicks the "Replay" button.
    public void PlayAgain()
    {
        // Starts a new Coroutine that begins loading the Game scene.
        StartCoroutine(loading());
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Store()
    {
        SceneManager.LoadScene("Store");
    }

    // Runs when the player clicks the "Main Menu" button.
    // Returns the user to the main menu scene.
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Returns an IEnumerator that begins loading the Game scene, waits a second, and changes the scene to begin gameplay.
    IEnumerator loading()
    {
        // Creates a yield instruction to wait for one second using scaled time.
        yield return new WaitForSeconds(0.5F);
        // SceneManager controls scene management at runtime.
        // LoadScene loads the Loading scene after waiting a second and then loads the main gameplay.
        SceneManager.LoadScene("Stage");
    }
}
 