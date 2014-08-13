using UnityEngine;
using System.Collections;

public class SeedDestruction : MonoBehaviour {

	public Transform seed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter ( Collider Seed ){
	
		Destroy (seed.gameObject);
	}
}
