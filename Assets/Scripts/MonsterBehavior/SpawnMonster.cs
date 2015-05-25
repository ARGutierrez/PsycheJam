﻿using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour {

    public float wait = 0f;
    public GameObject monster;
    public float timeBetweenSpawn;

    //all spawners will see these static variables
    public static int maxMonsters = 250;
    public static int currentMonsters = 0;

    public bool randomizeLocation;
    public float minDistanceToPlayer;
    private static float boundaryMinX;
    private static float boundaryMaxX;
    private static float boundaryMinZ;
    private static float boundaryMaxZ;

    private static Transform player;

	void Start () 
    {
        boundaryMinX = GameObject.Find("Boundary").transform.position.x;
        boundaryMaxX = GameObject.Find("BoundaryXZ").transform.position.x;
        boundaryMinZ = GameObject.Find("Boundary").transform.position.z;
        boundaryMaxZ = GameObject.Find("BoundaryXZ").transform.position.z;

        player = GameObject.Find("Player").transform;

        InvokeRepeating("spawn", wait, timeBetweenSpawn);
	}
	
	void Update () {
        //Debug.Log("Current:" + currentMonsters);
        //Debug.Log("Max:" + maxMonsters);
    }

    void spawn()
    {
        Debug.Log("Current:" + currentMonsters);
        Debug.Log("Max:" + maxMonsters);
        if (currentMonsters < maxMonsters)
        {
            Instantiate(monster, transform.position, Quaternion.identity);
            if (randomizeLocation)
                randomizePosition();
        }
    }

    void randomizePosition()
    {
        int maxLoop = 0;
        do
        {
            float newX = Random.Range(boundaryMinX, boundaryMaxX);
            float newZ = Random.Range(boundaryMinZ, boundaryMaxZ);

            transform.position = new Vector3(newX, transform.position.y, newZ);
            if (++maxLoop > 100)
            {
                Debug.Log("infinite loop prevention");
                transform.position = new Vector3(boundaryMaxX, transform.position.y, boundaryMaxZ);
                return;
            }
        }
        while (closeToPlayer());
    }

    bool closeToPlayer()
    {
       // Debug.Log("Distance" + Vector3.Distance(transform.position, player.position));
        return minDistanceToPlayer > Vector3.Distance(transform.position, player.position);
    }
}
