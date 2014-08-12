using UnityEngine;
using System.Collections;

public class proc_gen : MonoBehaviour {
	public Transform small, medium, big, seed; // assgn in reference in inspector
	public Transform [] prefabs; //an "array" is a list of things in one variable uses [] brackets
	public int spawnRadius = 8;
	// Use this for initialization
	void Start () {
		// spawn 100 small cubes

		int counter = 0;
		while (counter < spawnRadius * 4 ) { // as long as this expression is true it will keep looping
			Transform prefabtoSpawn; //starts blank
			int prefabIndex = Random.Range (0,4); // possible numbers 1 2 3 NOT 4
					if (prefabIndex == 0) {
						prefabtoSpawn = small; 
				} else if (prefabIndex == 1) {
							prefabtoSpawn = medium;
						} else if (prefabIndex == 2){
				prefabtoSpawn = big;
			}
			else { 
				prefabtoSpawn = seed;
			}
			

			
			Instantiate( prefabtoSpawn, new Vector3 (Random.Range (0,spawnRadius * 12), Random.Range (0,spawnRadius), 0), 
			            Quaternion.Euler (0,90,0) ); // rotates prefabs 90º  (90,90,-90)
			counter ++; // add 1 to counter after each loop
		}
	
	}
	void Update () {
	if (Input.GetKeyDown (KeyCode.Return)) {
		Application.LoadLevel (0);
	}
	}
}
