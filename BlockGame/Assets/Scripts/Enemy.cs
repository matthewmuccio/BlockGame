using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simply moves the current game object.
public class Enemy : MonoBehaviour
{
    // Refers to the RigidBody2D of which the script is a component.
    private Rigidbody2D rigidBody2D;
    // Refers to the force that should be applied on the Enemy objects at all times. The default is 300.
    public float force = 300F;

    // Use this for initialization.
    void Start()
    {
        // Get the RigidBody2D component and store the reference.
        rigidBody2D = GetComponent<Rigidbody2D>();
        // Simply add a force (the default is 300) when the object is instantiated.
        rigidBody2D.AddForce(new Vector2(force, force));
    }
}