using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

// Player controls the Player game object, his movement, and score calculation. The Player refers to the green square sprite
// "Blocky" that the user controls.
public class Player : MonoBehaviour
{
    // Stores the current speed of the Player.
    public Vector2 speed = new Vector2(10, 10);
    // Refers to Text object on screen that stores the current score in a text field.
    public Text scoreText;

    // Refers to the RigidBody2D of which the script is a component.
    private Rigidbody2D rigidBody2D;
    // Stores the current score of the current game.
    private int score;
    // Store the movement of the Player and the component.
    private Vector2 movement;
    // Stores the current time in seconds since the beginning of the frame (the first frame when the Player is created).
    private float startTime;
    
    // Use this for initialization.
    void Start()
    {
        // Sets startTime to the current time in seconds at the beginning of the frame.
        startTime = Time.time;
        // Deactivates the current Game Object from the game.
        gameObject.SetActive(true);
        // Initializes the score to 0.
        score = 0;
        // Updates the current score text to "Score: 0"
        UpdateScoreText();
    }

    // FixedUpdate is called at every fixed framerate frame.
    // Use this method over Update when dealing with physics.
    void FixedUpdate()
    {
        // Every frame, calculate the score and update the score text accordingly.
        UpdateScoreText();
        // Obtain the axis information for the X-axis (the value of the virtual X-axis).
        float inputX = Input.GetAxis("Horizontal");
        // Obtain the value of the virtual Y-axis.
        float inputY = Input.GetAxis("Vertical");

        // If the current RigidBody2D is null, get the component and store the reference.
        if (rigidBody2D == null)
            rigidBody2D = GetComponent<Rigidbody2D>();

        // Set movement per direction in a new Vector2 (a new vector with x and y components.
        movement = new Vector2(speed.x * inputX,
                                speed.y * inputY);

        // Move the Player game object by setting the velocity of the RigidBody2D to the current value of value.
        rigidBody2D.velocity = movement;
    }

    // Runs when the Player collides with various objects (the boundaries of the screen and the enemies).
    // Essentially keeps the Player on-screen.
    void OnCollisionEnter2D(Collision2D collision)
    {
        // If the object with which the Player is currently colliding is a wall:
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Checks the name (string representation) of the current game object that is colliding with the Player
            // and executes a block accordingly using a switch statement.
            switch (collision.gameObject.name)
            {
                // If the current game object that is colliding with the Player is the upper-most wall, add a force in the downward direction.
                case "Up":
                    rigidBody2D.AddForce(Vector2.down * 5, ForceMode2D.Force);
                    break;
                // If the current game object that is colliding with the Player is the down-most wall, add a force in the upward direction.
                case "Down":
                    rigidBody2D.AddForce(Vector2.up * 5, ForceMode2D.Force);
                    break;
                // If the current game object that is colliding with the Player is the left-most wall, add a force in the rightward direction.
                case "Left":
                    rigidBody2D.AddForce(Vector2.right * 5, ForceMode2D.Force);
                    break;
                // If the current game object that is colliding with the Player is the right-most wall, add a force in the leftward direction.
                case "Right":
                    rigidBody2D.AddForce(Vector2.left * 5, ForceMode2D.Force);
                    break;
            }
        }
        // Otherwise if the current game object that is colliding with the Player is something else (an enemy object), run the OnPlayerHit() method.
        else
            OnPlayerHit();
    }

    // Runs when the Player has collided with an Enemy game object, which ends the game.
    void OnPlayerHit()
    {
        // Afterward, load the Main Menu scene (will eventually be loading the GameOver scene).
        SceneManager.LoadScene("Menu");
        // If the current high score stored in PlayerPrefs, which stores and accesses player preferences between game sessions,
        // is less than the Player's current score on death, update the high score value in PlayerPrefs to the current score.
        if (PlayerPrefs.GetFloat("highScore") < score)
            PlayerPrefs.SetFloat("highScore", score);

        // Remove the current game object from the scene (both may be unnecessary).
        //Destroy(this);
        //gameObject.SetActive(false);
    }

    // Adds the parameter newScore the score field.
    // Will be utilized more later with power-ups.
    public void AddScore(int newScore)
    {
        score += newScore;
    }

    // Updates the Text that stores the Player's current score in the Game scene.
    void UpdateScoreText()
    {
        // Set score to the difference of the current time and the startTime field.
        score = (int)(Time.time - startTime);
        // Update the Text that stores the score on-screen to say "Score: " and then the current score field.
        scoreText.text = "Score: " + score;
    }
}