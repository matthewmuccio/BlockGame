using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseEvent : MonoBehaviour
{
    private GameManager gameManager;
    private bool isPaused;

    void OnEnable()
    {
        SetInitialReference();
    }

    void OnDisable()
    {

    }

    void SetInitialReference()
    {
        gameManager = GetComponent<GameManager>();
    }

    void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
