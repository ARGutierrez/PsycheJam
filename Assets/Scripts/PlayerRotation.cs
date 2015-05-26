using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	public float speed;
	//public float jumpForce;
	private SixenseInput.Controller controllerR; //left Hydra controller
	private float yRotation;
	
	
	// Use this for initialization
	void Start () {
		yRotation = transform.eulerAngles.y;
		controllerR = SixenseInput.GetController (SixenseHands.RIGHT); // get left controller
	}
	void Update() {
		if(controllerR != null && controllerR.Enabled && controllerR.GetButtonDown(SixenseButtons.JOYSTICK))
			OVRManager.display.RecenterPose();
	}
	// Update is called once per frame
	void LateUpdate () {
		if (controllerR == null)
			controllerR = SixenseInput.GetController (SixenseHands.RIGHT);
		if (controllerR != null && controllerR.Enabled && controllerR.JoystickX != 0)
			MoveWithHydra ();
		else
			MoveWithDancePad ();
	}
	
	void MoveWithHydra()
	{
		yRotation += controllerR.JoystickX * speed;
		transform.eulerAngles = new Vector3(0, yRotation, 0);
	}
	
	void MoveWithDancePad()
	{
		yRotation += Input.GetAxis ("Horizontal") * speed;
		transform.eulerAngles = new Vector3(0, yRotation, 0);
	}
}
