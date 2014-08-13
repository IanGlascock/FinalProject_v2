using UnityEngine;
using System.Collections;

public class MonsterAnimation : MonoBehaviour {


	void Start () {
		renderer.enabled = false;
		StartCoroutine (MonsterFlicker() ); 

	}
	IEnumerator MonsterFlicker () {		
		Debug.Log ( "Animation coroutine started!");
		yield return 0; // wait one frame
		yield return 0; // wait one frame

		while (true) {


			yield return new WaitForSeconds (0.3f);
			//Debug.Log ("2.3 seconds have elapsed");
			renderer.enabled = true;
			yield return new WaitForSeconds (0.3f);
			renderer.enabled = false; 
		}
	}

	//You can use either gameObject.SetActive(bool) or renderer.enabled = bool to turn images on or off.




	void Update () {
	
	}
}
