using UnityEngine;
using System.Collections;

public class PushEnemy : MonoBehaviour {
	public float force;
	public Vector3 explosionPointOffset;
	public float radius;
	public AudioClip[] clips;

	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	AudioClip chooseClip(AudioClip[] array)
	{
		return array[Random.Range(0, array.Length)];
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Enemy")) 
		{
			audioSource.clip = chooseClip (clips);
			audioSource.Play ();

//			Debug.Log ("Points colliding: " + other.contacts.Length);
//			Debug.Log ("First point that collided: " + other.contacts[0].point);
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
			Vector3 point = other.contacts[0].point + explosionPointOffset;
			rb.AddExplosionForce(force, point, radius);
		}
	}
}
