using UnityEngine;
using System.Collections;

public class FinishlineLevel3 : MonoBehaviour {
	public Transform player;
	public static bool win = false;

	void OnTriggerEnter ( Collider Finishlinetest ){
		Application.LoadLevel("endscene");
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
