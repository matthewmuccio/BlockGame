using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameManager manages the game, its scene, components, and objects.
// Currently not working and obsolete, but will implement eventually.
public class GameManager : MonoBehaviour
{
    /**
    public delegate void GameManagerEventHandler();

    public event GameManagerEventHandler PlayEvent;
    public event GameManagerEventHandler PauseEvent;
    public event GameManagerEventHandler GameOverEvent;

    public GameObject player;
    public GameObject enemy;

    public bool isGameStarted;
    public bool isGamePaused;
    public bool isGameOver;

    public void CallEventPlayToggle()
    {
        if (PlayEvent != null)
        {
            isGameStarted = true;
            PlayEvent();
        }
    }

    public void CallEventPauseToggle()
    {
        if (PauseEvent != null)
        {
            isGamePaused = true;
            PauseEvent();
        }
    }

    public void CallEventGameOverToggle()
    {
        if (GameOverEvent != null)
        {
            isGameOver = true;
            GameOverEvent();
        }
    }

    public IEnumerator spawnEnemy()
    {
        yield return new WaitForSeconds(1F);
        Instantiate(enemy);
    }*/
}