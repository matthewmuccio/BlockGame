using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GUIText scoreText;
    static int highScore = 0;

	// Use this for initialization
	void Start()
    {
        scoreText.text = "Score: " + highScore;
        PlayerPrefs.GetInt("highScore", highScore);
        highScore = PlayerPrefs.GetInt("highScore", highScore);
	}
	
	// Update is called once per frame
	void Update()
    {
        scoreText.text = "Score: " + highScore;
	}
}
