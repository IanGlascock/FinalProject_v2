using UnityEngine;
using System.Collections;

public class KuansController : MonoBehaviour {
	
	public float turnSpeed = 30f;
	public float moveSpeed = 50f;
	public float jumpForce = 100f;
	void Update () {
				
	}
	
	void FixedUpdate (){
		GetComponent<Rigidbody> ().AddForce (transform.forward * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime);
		GetComponent<Rigidbody> ().AddForce (transform.right * Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime);
		
		if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpForce);
		}
	}
}