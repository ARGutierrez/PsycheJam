using UnityEngine;
using System.Collections;

public class PushEnemy : MonoBehaviour {
	public float force;
	public Vector3 explosionPointOffset;
	public float radius;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Enemy")) 
		{
//			Debug.Log ("Points colliding: " + other.contacts.Length);
//			Debug.Log ("First point that collided: " + other.contacts[0].point);
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			Vector3 point = other.contacts[0].point + explosionPointOffset;
			rb.AddExplosionForce(force, point, radius);
		}
	}
}
