using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterPhysics))]

public class CharacterControls : MonoBehaviour {

	public float speed = 20f; 
	public float acceleration = 25f;
	public float jumpForce = 40;
	public float gravity = 20f;

	private float currentSpeed;
	private float targetSpeed;
	private Vector3 amountToMove;

	private CharacterPhysics characterPhysics;

	// Use this for initialization
	void Start () {
		characterPhysics = GetComponent<CharacterPhysics> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Movement
		targetSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		currentSpeed = IncrementTowards(currentSpeed, targetSpeed,acceleration);

		if (characterPhysics.grounded) {
			amountToMove.y = 0; //Reset gravity

			//W to jump
			if (Input.GetKeyDown (KeyCode.Space)) {
				amountToMove.y = jumpForce;
			}
		}	



		amountToMove.x = currentSpeed;
		amountToMove.y -= gravity * Time.deltaTime;
		characterPhysics.Move (amountToMove * Time.deltaTime);
	}
	//Increment currentSpeed towards targetSpeed (n = current, a = accel)
	private float IncrementTowards(float n, float target, float a) {
		//If current speed is equal to the target, 
		if (n == target) {
			//Don't change speed
			return n;	
		} // Should n be increased or decreased to get closer to target?
		else {float dir = Mathf.Sign(target - n); 
			n += a * Time.deltaTime * dir;
			//If n is passed the target then return target, otherwise return currentSpeed
			return (dir == Mathf.Sign(target-n))? n: target; 
		}
	}
}

