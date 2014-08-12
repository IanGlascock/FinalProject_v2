using UnityEngine;
using System.Collections;

public class CharacterPhysics : MonoBehaviour {

	public LayerMask collisionMask;

	private BoxCollider collider;
	private Vector3 size;
	private Vector3 center;

	private float skin = .005f;

	[HideInInspector]
	public bool grounded;

	Ray ray;
	Ray rays;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		collider = GetComponent<BoxCollider> ();
		size = collider.size;
		center = collider.center;
	}


	//Will handle collisions for our character
	public void Move(Vector3 amountToMove) {

		float deltaY = amountToMove.y; 
		float deltaX = amountToMove.x;
		Vector3 pos = transform.position;


		grounded = false;
		for (int i = 0; i <3; i ++) {
						float dir = Mathf.Sign (deltaY);
						float dirX = Mathf.Sign (deltaX);
						float x = (pos.x + center.x - size.x / 2) + size.x / 2 * i; //Raycasts on the leftmost, center and rightmost points
						float y = pos.y + center.y + size.y / 2 * dir; // Raycasts from bottom of the collider

						float X = pos.x + center.x + size.x / 2 * dirX;
						float Y = (pos.y + center.y - size.y / 2) + size.y / 2 * i;

						ray = new Ray (new Vector3 (x, y), new Vector3 (0, dir));
						rays = new Ray (new Vector3 (X, Y), new Vector3 (0, dirX));
		

						Debug.DrawRay (ray.origin, ray.direction);
						Debug.DrawRay (rays.origin, rays.direction);

						if (Physics.Raycast (ray, out hit, Mathf.Abs (deltaY), collisionMask)) {
								//Define the distance between the character and the ground
								float distance = Vector3.Distance (ray.origin, hit.point);

								//Stop characters downwards movement after coming within the skin width of a collider
								if (distance > skin) {
										deltaY = distance * dir + skin;

								} else {
										deltaY = 0;
								}
								grounded = true;
								break;

						
						}
				}

		Vector3 finalTransform = new Vector3(deltaX,deltaY);


		transform.Translate (finalTransform);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
