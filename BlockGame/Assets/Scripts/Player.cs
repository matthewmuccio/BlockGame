using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    // The speed of the Player.
    public Vector2 speed = new Vector2(10, 10);
    // Refers to Text object on screen.
    public Text scoreText;

    // Store the movement of the Player and the component.
    private Vector2 movement;
    private Rigidbody2D rigidBody2D;
    private int score;
    private float startTime;
    
    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        gameObject.SetActive(true);
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called at every fixed framerate frame.
    // Use this method over Update when dealing with physics.
    void FixedUpdate()
    {
        CalculateScore();
        // Obtain the axis information.
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Movement per direction.
        movement = new Vector2(speed.x * inputX,
                                speed.y * inputY);

        // Get the component and store the reference.
        if (rigidBody2D == null)
            rigidBody2D = GetComponent<Rigidbody2D>();

        // Move the game object (Player).
        rigidBody2D.velocity = movement;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "UpWall")
        {
            rigidBody2D.AddForce(Vector2.down * 5, ForceMode2D.Force);
        }
        else if (collision.gameObject.name == "DownWall")
        {
            rigidBody2D.AddForce(Vector2.up * 5, ForceMode2D.Force);
        }
        else if (collision.gameObject.name == "LeftWall")
        {
            rigidBody2D.AddForce(Vector2.right * 5, ForceMode2D.Force);
        }
        else if (collision.gameObject.name == "RightWall")
        {
            rigidBody2D.AddForce(Vector2.left * 5, ForceMode2D.Force);
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            OnPlayerHit();
        }
    }

    void OnPlayerHit()
    {
        if (PlayerPrefs.GetFloat("highScore") < score)
            PlayerPrefs.SetFloat("highScore", score);

        gameObject.SetActive(false);
        Destroy(this);
        SceneManager.LoadScene(0);
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    void CalculateScore()
    {
        float time = Time.time - startTime;
        score = (int)time;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}