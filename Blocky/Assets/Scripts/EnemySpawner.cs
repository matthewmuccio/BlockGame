using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// EnemySpawner refers to the empty game object on the Game scene which will determine where the Enemy objects will spawn from.
// Its values and fields will change each frame.
public class EnemySpawner : MonoBehaviour
{
    // Refers to the empty game object on the Game scene where the Enemies will spawn.
    public GameObject spawn;
    // Stores the spawn rate (in seconds) at which the Enemies will spawn. The default is every 3 seconds.
    public float spawnRate = 3F;
    // Stores the next time (in seconds) at which an Enemy should spawn to check when it should be spawned.
    private float nextSpawn = 0.0F;
	
	// Update is called once per frame.
	void Update()
    {
        // If the current time (in seconds) is greater than or equal to the current time + the current spawn rate (3 seconds):
		if (Time.time > nextSpawn)
        {
            // Set the next time at which an Enemy should spawn to the current time (in seconds) plus the spawnRate field.
            nextSpawn = Time.time + spawnRate;
            // Create a Vector3 object that stores the x, y, z coordinates of the screen converted from screen space (pixels) to world space (coordinates)
            // so that a new Enemy object can be instantiated at a random position on the screen. (z will always be 0).
            Vector3 screen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
            // Then it is time to instantiate a new Enemy object at a random x-y cooordinates and add it to the screen.
            // Random coordinates are calculated using the screen variable.
            Instantiate(spawn, new Vector2(Random.Range(-screen.x, screen.x), Random.Range(-screen.y, screen.y)), Quaternion.identity);
        }
	}
}