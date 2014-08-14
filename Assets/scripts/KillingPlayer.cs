using UnityEngine;
using System.Collections;

public class KillingPlayer : MonoBehaviour {
	public Transform player; 
	public static bool killed = false;
	
	void OnTriggerEnter ( Collider MONSTER ){
		killed = true;
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
