using UnityEngine;
using System.Collections;

public class SeedTriggerTest : MonoBehaviour {
	
	//public float speed = 300;
	
	void Update () {
		//transform.Rotate(Vector3.forward * speed * Time.deltaTime,Space.World);
	}
	
	
	void OnTriggerEnter(Collider c) {
		if (c.tag == "Player") {
			Debug.Log ("Die");
		}
	}
}