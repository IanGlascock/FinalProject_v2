using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public static int currentScore = 0;
	public float offsetY = 100f;
	public float sizeX = 100f;
	public float sizeY = 100f;

	void OnGUI () {
		GUI.Box (new Rect (Screen.width / 2f - sizeX /2f, offsetY , sizeX , sizeY),"Score:\n" + currentScore );
		}
}
