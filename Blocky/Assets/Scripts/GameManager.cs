using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private GameManager()
    {

    }

    void Awake()
    {
        
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<GameManager>();

            return instance;
        }   
    }

    public void Pause(bool isPaused)
    {

    }
}