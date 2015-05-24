using UnityEngine;
using System.Collections;

public class ResetOVRPos : MonoBehaviour 
{
	private SixenseInput.Controller controllerR;

	// Use this for initialization
	void Start () {
		controllerR = SixenseInput.GetController (SixenseHands.RIGHT);
	}
	
	// Update is called once per frame
	void Update () {
		if(controllerR == null)
			controllerR = SixenseInput.GetController (SixenseHands.RIGHT);
		if ((controllerR != null && controllerR.Enabled && controllerR.GetButtonDown(SixenseButtons.JOYSTICK)) || Input.GetKeyDown("space"))
		{
			OVRManager.display.RecenterPose();
		}
	}
}
