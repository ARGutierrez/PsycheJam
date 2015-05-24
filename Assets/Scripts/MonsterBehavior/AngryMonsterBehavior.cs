using UnityEngine;
using System.Collections;

public class AngryMonsterBehavior : MonoBehaviour {

    public float speed;

    private static Transform target;

    void Start()
    {
        target = GameObject.Find("Player 1").transform;
    }
	
	// Update is called once per frame
	void Update () {
        moveTowardTargetAngrily();
	}

    void moveTowardTargetAngrily()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
