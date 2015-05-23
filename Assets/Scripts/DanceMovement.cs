using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
//	private Rigidbody rb;
//	public float speed;
//	public float jumpForce;
//	private Vector3 direction;
//	private SixenseInput.Controller controllerL; //left Hydra controller
//
//
//	// Use this for initialization
//	void Start () {
//		rb = gameObject.GetComponent<Rigidbody> ();
//		controllerL = SixenseInput.GetController (SixenseHands.LEFT); // get left controller
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (controllerL == null)
//			controllerL = SixenseInput.GetController (SixenseHands.LEFT);
//		if (controllerL != null && controllerL.Enabled && (controllerL.JoystickX != 0 || controllerL.JoystickY != 0))
//			MoveWithHydra ();
//		else
//			MoveWithDancePad ();
//	}
//
//	void MoveWithHydra()
//	{
//		float horizontal = controllerL.JoystickX;
//		float vertical = controllerL.JoystickY;
//		
//		// Get the input vector from analog stick
//		Vector3 directionVector = new Vector3(horizontal, 0, vertical);
//		
//		if (directionVector != Vector3.zero)
//		{
//			// Get the length of the directon vector and then normalize it
//			// Dividing by the length is cheaper than normalizing when we already have the length anyway
//			float directionLength = directionVector.magnitude;
//			directionVector = directionVector / directionLength;
//			
//			// Make sure the length is no bigger than 1
//			directionLength = Mathf.Min(1.0f, directionLength);
//			
//			// Make the input vector more sensitive towards the extremes and less sensitive in the middle
//			// This makes it easier to control slow speeds when using analog sticks
//			directionLength = directionLength * directionLength;
//			
//			// Multiply the normalized direction vector by the modified length
//			directionVector = directionVector * directionLength;
//		}
//		
//		// Apply the direction to the CharacterMotor
//		rb.AddForce(directionVector * speed);
//	}
//
//	void MoveWithDancePad()
//	{
//		float x = Input.GetAxis ("Horizontal");
//		float y = Input.GetAxis ("Vertical");
//		direction = new Vector3(x, 0, y);
//		
//		//		bool j1 = Input.GetButton ("Jump1");
//		//		bool j2 = Input.GetButton ("Jump2");
//		//		bool jup1 = Input.GetButtonUp ("Jump1");
//		//		bool jup2 = Input.GetButtonUp ("Jump2");
//		//		if(j1 && jup2 || j2 && jup1 || jup1 && jup2)
//		//			rb.AddForce(transform.up * jumpForce);
//		//		else
//		rb.AddForce (direction * speed);
//	}
}
