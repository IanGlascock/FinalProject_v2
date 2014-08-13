using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
	public Texture2D playNormal;
	public Texture2D playHover;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseEnter () {
		guiTexture.texture = playHover; 
	}
	
	void OnMouseExit () {
		guiTexture.texture = playNormal; 
	}
	
	void OnMouseDown () {
		Application.LoadLevel("KuanLevel2"); 
	}
}
