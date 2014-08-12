using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.Box (new Rect(250,100,200, 200), "Menu");
		
		if (GUI.Button( new Rect (300, 150, 100, 50), "Restart")) {
			Application.LoadLevel ("KuanScene1");
		}
		else if (GUI.Button( new Rect (300, 250, 100, 50), "Quit")) {
			Application.Quit();
		}
	}
}
