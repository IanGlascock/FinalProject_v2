using UnityEngine;
using System.Collections;

public class Finishline : MonoBehaviour {
	public Transform player;
	public static bool win = false;

	void OnTriggerEnter ( Collider Finishlinetest ){
		win = true;
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
