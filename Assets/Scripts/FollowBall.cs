using UnityEngine;
using System.Collections;

public class FollowBall : MonoBehaviour {
	public Transform ball;
	private float x;
	private float y;
	private float z;

	void Awake()
	{

	}
	void Start () 
	{
		x = transform.position.x - ball.position.x;
		y = transform.position.y - ball.position.y;
		z = transform.position.z - ball.position.z;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(ball.position.x + x, ball.position.y + y, ball.position.z + z);
	}
}
