using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawn;
    float randX;
    Vector2 spawnLocation;
    public float spawnRate = 2F;
    float nextSpawn = 0.0F;

	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
		if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-9F, 9F);
            spawnLocation = new Vector2(randX, transform.position.y);
            Instantiate(spawn, spawnLocation, Quaternion.identity);
        }
	}
}