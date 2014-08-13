using UnityEngine;
using System.Collections;

public class KillingPlayer : MonoBehaviour {
	public Transform player; 
	
	void OnTriggerEnter ( Collider MONSTER ){
		Destroy (player.gameObject ); 
		audio.Play (); 
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
