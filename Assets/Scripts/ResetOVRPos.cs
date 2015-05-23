using UnityEngine;
using System.Collections;

public class ResetOVRPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("left ctrl"))
		{
			OVRManager.display.RecenterPose();
		}
	}
}
