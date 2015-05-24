using UnityEngine;
using System.Collections;

public class FollowBall : MonoBehaviour {
	public Transform ball;
//	private float x;
//	private float y;
//	private float z;

	private Quaternion origRot;

	void Awake()
	{
		//origRot = transform.rotation;
	}
	void Start () 
	{
//		x = transform.position.x - ball.position.x;
//		y = transform.position.y - ball.position.y;
//		z = transform.position.z - ball.position.z;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.position = new Vector3(ball.position.x + x, ball.position.y + y, ball.position.z + z);
		//transform.rotation = origRot * ball.localRotation; //new Quaternion (origRot.x + ball.rotation.x, ball.rotation.y, ball.rotation.z, ball.rotation.w);
		transform.rotation = ball.localRotation;
	}
}
