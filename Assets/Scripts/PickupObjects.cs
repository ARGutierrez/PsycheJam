using UnityEngine;
using System.Collections;

public class PickupObjects : MonoBehaviour {

    private int numObjects = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(numObjects);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUpObject"))
        {
            other.GetComponent<PickedUp>().onPickUp();
            numObjects++;
        }
    }
}
