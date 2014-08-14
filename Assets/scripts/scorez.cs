using UnityEngine;
using System.Collections;

public class scorez : MonoBehaviour {
	public int coinValue = 1;
	public AudioSource seedSound;
	
	void OnTriggerEnter ( Collider Seed ){
		
		Score.currentScore += coinValue;
		seedSound.Play ();
		//Destroy (seed.gameObject); 
	}
	
}
