using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simply moves the current game object.
public class Enemy : MonoBehaviour
{
    // Fields
    private Rigidbody2D rigidBody2D;
    public float force;

    // Speed of the current object.
    //public Vector2 speed = new Vector2(10, 10);

    // Moving direction of the current object.
    //public Vector2 direction = new Vector2(-1, 0);

    // Store the movement of the Player and the component.
    //private Vector2 movement;
    //private Rigidbody2D rigidBodyComponent;

    // Use this for initialization
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.AddForce(new Vector2(force, force));
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        //movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }

    // FixedUpdate is called at every fixed framerate frame.
    // Use this method over Update when dealing with physics.
    void FixedUpdate()
    {
        // Get the component and store the reference.
        //if (rigidBodyComponent == null)
        //    rigidBodyComponent = GetComponent<Rigidbody2D>();

        // Move the game object (Player).
        //rigidBodyComponent.velocity = movement;
    }
}