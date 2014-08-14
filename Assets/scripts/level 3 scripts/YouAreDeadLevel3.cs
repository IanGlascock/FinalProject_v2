using UnityEngine;
using System.Collections;

public class YouAreDeadLevel3: MonoBehaviour {
	public float boxoffsetY = 100f;
	public float boxsizeX = 200f;
	public float boxsizeY = 200f;
	public float restartoffsetY = 150f;
	public float restartsizeX = 100f;
	public float restartsizeY = 50f;
	public float quitoffsetY = 250f;
	public float quitsizeX = 100f;
	public float quitsizeY = 50f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnGUI(){

		if (KillingPlayer.killed == true) {
			GUI.Box (new Rect (Screen.width / 2f - boxsizeX /2f, boxoffsetY , boxsizeX , boxsizeY), "You Are DEAD!");
		
			if (GUI.Button (new Rect (Screen.width / 2f - restartsizeX /2f, restartoffsetY , restartsizeX , restartsizeY), "Restart")) {
								Application.LoadLevel ("Level1");
								KillingPlayer.killed = false;
								Score.currentScore =0;
			} else if (GUI.Button (new Rect (Screen.width / 2f - quitsizeX /2f, quitoffsetY , quitsizeX , quitsizeY), "Quit")) {
								Application.Quit ();
						}
				}
	}
}
