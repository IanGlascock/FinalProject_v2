using UnityEngine;
using System.Collections;

public class SeedTrigger : MonoBehaviour {

	public Transform seed;
	public float speed = 300;
	public bool triggered;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * speed * Time.deltaTime,Space.World);

	}

	void onTriggerEnter (Collider c) {
		if (c.tag == "Player") {
			Debug.Log ("Die");

			triggered = true;
			Destroy (seed.gameObject);
		}

	}
}
