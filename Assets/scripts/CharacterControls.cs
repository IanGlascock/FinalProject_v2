using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterPhysics))]

public class CharacterControls : MonoBehaviour {

	public float speed = 20f; 
	public float acceleration = 25f;
	public float jumpForce = 10;
	public float airJumpForce = 10;
	public float gravity = 20f;

	public bool airborne;

	private int notAirborne = 0;
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



		if (characterPhysics.stopped) {
			targetSpeed = 0;
			currentSpeed = 0;
			}

		//Movement
		targetSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		currentSpeed = IncrementTowards(currentSpeed, targetSpeed,acceleration);

		if (characterPhysics.grounded) {
			amountToMove.y = 0; //Reset gravity
			notAirborne = 1;
			//W to jump
			if (Input.GetKeyDown (KeyCode.W)) {
				amountToMove.y = jumpForce;
				audio.Play ();

				airborne = true;
				//airborne += 1;
			}

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				amountToMove.y = jumpForce;
				audio.Play ();
			}
			if (Input.GetKeyDown (KeyCode.Space)) {
				amountToMove.y = jumpForce;
				audio.Play ();
			}
				// must add aduio fle "PlayerJump2" to Player model.
				
			}
			
//		if (airborne > 0) {
		//	amountToMove.y = 0;

			if (Input.GetKeyDown (KeyCode.W) && airborne == true) {
				amountToMove.y = airJumpForce;
				audio.Play ();
				notAirborne += 1;
//				airborne -= 1;



		}

//		if (airborne && (Input.GetKeyDown (KeyCode.W))) {
//		 	  airborne = false;

//		}

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

