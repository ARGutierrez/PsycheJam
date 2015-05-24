using UnityEngine;
using System.Collections;

public class BouncyMonsterBehavior : MonoBehaviour
{

    public float initialSpeed;

	// Use this for initialization
	void Start () {

        gameObject.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * initialSpeed);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
