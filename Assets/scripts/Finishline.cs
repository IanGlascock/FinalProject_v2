using UnityEngine;
using System.Collections;

public class Finishline : MonoBehaviour {
	public Transform player;

	void OnTriggerEnter ( Collider Finishlinetest ){
		Application.LoadLevel (0); 
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
