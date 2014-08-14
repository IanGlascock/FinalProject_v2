using UnityEngine;
using System.Collections;

public class YouWinSeeYouInNextLevel : MonoBehaviour {
	public float boxoffsetY = 100f;
	public float boxsizeX = 200f;
	public float boxsizeY = 200f;
	public float nextoffsetY = 150f;
	public float nextsizeX = 100f;
	public float nextsizeY = 50f;
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
		
		if (Finishline.win == true) {
			GUI.Box (new Rect (Screen.width / 2f - boxsizeX /2f, boxoffsetY , boxsizeX , boxsizeY), "Congratulation!");
			
			if (GUI.Button (new Rect (Screen.width / 2f - nextsizeX /2f, nextoffsetY , nextsizeX , nextsizeY), "Next")) {
				Application.LoadLevel ("Level3");
				Finishline.win= false;
				Score.currentScore =0;
			} else if (GUI.Button (new Rect (Screen.width / 2f - quitsizeX /2f, quitoffsetY , quitsizeX , quitsizeY), "Quit")) {
				Application.Quit ();
			}
		}
	}
}
