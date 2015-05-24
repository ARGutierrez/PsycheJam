using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour {

    public GameObject monster;
    public float timeBetweenSpawn;

    //all spawners will see this static variable
    public static int maxMonsters = 100;
    public static int currentMonsters = 0;

	void Start () {
        InvokeRepeating("spawn", 0f, timeBetweenSpawn);
	}
	
	void Update () {
        Debug.Log("Current:" + currentMonsters);
        Debug.Log("Max:" + maxMonsters);
    }

    void spawn()
    {
        if (currentMonsters < maxMonsters)
        {
            Instantiate(monster, transform.position, Quaternion.identity);
            currentMonsters++;
        }
    }
}
