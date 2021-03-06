﻿using UnityEngine;
using System.Collections;

public class ScrollingBox : MonoBehaviour {

	// allows for access public to var. which has context
	float startSpeed = 1f;
	float acceleration = 0.01f;
	float maxSpeed = 5;
	// allows changing speed for additional levels
	public float level = 1f;
	// acces too variriable direction 
	public Vector3 direction; 

	
	// Use this for initialization
	void Start () {
		//checks position of object 
		Debug.Log (GetComponent<Transform>().position);	
		Debug.Log ("Killbox is moving");
	}
	
	
	// Update is called once per frame
	void Update () {
		//                             add to sellf ammount         * change in time to adjust for dif. in FPS
		//GetComponent<Transform>().position += new Vector3(1f,1f,0f) * Time.deltaTime * speed;
		// makes the direction a variable that is editable in Unity
		if (GetComponent<Transform>().position.x <= 92f) {
			GetComponent<Transform>().position += direction * Time.deltaTime * startSpeed;
			if (startSpeed <= maxSpeed) { 
				startSpeed += acceleration; 
			}

		}
		else 
			Debug.Log ("Killbox stopped");
		// need to slowly increase speed as the level continues 
		// need to stop the movement of the thing at the end of the level
		
		// when character or teeth --> touch End cube 
		// > end camera movement 
		// > when teach --> touch exit end level show score 
	}
}