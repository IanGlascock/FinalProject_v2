using UnityEngine;
using System.Collections;

public class Finishline : MonoBehaviour {
	public Transform player;

	void OnTriggerEnter ( Collider Finishlinetest ){
		Application.LoadLevel (0); 

		GUI.Box (new Rect(250,100,200, 200), "Menu");
		
		if (GUI.Button( new Rect (300, 150, 100, 50), "Restart")) {
			Application.LoadLevel ("KuanScene1");
		}
		else if (GUI.Button( new Rect (300, 250, 100, 50), "Quit")) {
			Application.Quit();
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
