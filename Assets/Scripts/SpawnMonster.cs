using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour {

    public GameObject monster;
    public float timeBetweenSpawn;
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawn", 0f, timeBetweenSpawn);
	}
	
	// Update is called once per frame
	void Update () {

    }

    void spawn()
    {
        Instantiate(monster, transform.position, Quaternion.identity);
    }
}
