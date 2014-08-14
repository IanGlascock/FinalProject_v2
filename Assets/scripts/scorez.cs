using UnityEngine;
using System.Collections;

public class scorez : MonoBehaviour {
	public int coinValue = 1;
	public AudioSource seedSound;
	public Collider seedcollider;
	
	void OnTriggerEnter (Collider seedcollider){
		
		Score.currentScore += coinValue;
		seedSound.Play ();
		//Destroy (seed.gameObject); 
	}
	
}
