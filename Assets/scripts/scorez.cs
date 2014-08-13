using UnityEngine;
using System.Collections;

public class scorez : MonoBehaviour {
	public Transform seed; 
	public int coinValue = 1;

	void OnTriggerEnter ( Collider player ){
		audio.Play ();
		Score.currentScore += coinValue;

		Destroy (seed.gameObject ); 
	
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
