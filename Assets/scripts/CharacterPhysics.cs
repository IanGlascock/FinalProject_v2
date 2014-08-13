using UnityEngine;
using System.Collections;


[RequireComponent (typeof(BoxCollider))]
public class CharacterPhysics : MonoBehaviour {

	public LayerMask collisionMask;

	private BoxCollider collider;
	private Vector3 s;
	private Vector3 c;

	private Vector3 originalSize;
	private Vector3 originalCenter;
	private float colliderScale;

	private float skin = .005f;

	[HideInInspector]
	public bool grounded;
	[HideInInspector]
	public bool stopped;

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		collider = GetComponent<BoxCollider> ();
		colliderScale = transform.localScale.x;
		
		originalSize = collider.size;
		originalCenter = collider.center;
		SetCollider(originalSize,originalCenter);
	}


	//Will handle collisions for our character
	public void Move(Vector3 amountToMove) {

		float deltaY = amountToMove.y; 
		float deltaX = amountToMove.x;
		Vector3 pos = transform.position;


				grounded = false;
				for (int i = 0; i <3; i ++) {
					float dir = Mathf.Sign (deltaY);
					float x = (pos.x + c.x - s.x / 2) + s.x / 2 * i; //Raycasts on the leftmost, center and rightmost points
					float y = pos.y + c.y + s.y / 2 * dir; // Raycasts from bottom of the collide
						

					ray = new Ray (new Vector3 (x, y), new Vector3 (0, dir));
					Debug.DrawRay (ray.origin, ray.direction);

					if (Physics.Raycast (ray, out hit, Mathf.Abs (deltaY) + skin, collisionMask)) {
					//Define the distance between the character and the ground
						float distance = Vector3.Distance (ray.origin, hit.point);

					//Stop characters downwards movement after coming within the skin width of a collider
						if (distance > skin) {
							deltaY = distance * dir - skin * dir;

						} else {
							deltaY = 0;
							}
						grounded = true;
						break;

						
					}
				}

				stopped = false;
				for (int i = 0; i <3; i ++) {
					float dir = Mathf.Sign (deltaX);
					float x = pos.x + c.x + s.x / 2 * dir;
					float y = (pos.y + c.y - s.y / 2) + s.y / 2 * i; // Raycasts from bottom of the collide
			
			
					ray = new Ray (new Vector3 (x, y), new Vector3 (dir, 0));
					Debug.DrawRay (ray.origin, ray.direction);
			
					if (Physics.Raycast (ray, out hit, Mathf.Abs (deltaX) + skin, collisionMask)) {
						//Define the distance between the character and the ground
						float distance = Vector3.Distance (ray.origin, hit.point);
				
						//Stop characters downwards movement after coming within the skin width of a collider
						if (distance > skin) {
						deltaX = distance * dir - skin * dir;
						
						} else {
						deltaX = 0;
						}
						stopped = true;
						break;
					}
				}

			if (!grounded && !stopped) {
			Vector3 playerDir = new Vector3(deltaX,deltaY);
			Vector3 o = new Vector3(pos.x + c.x + s.x/2 * Mathf.Sign(deltaX),pos.y + c.y + s.y/2 * Mathf.Sign(deltaY));
			ray = new Ray(o,playerDir.normalized);
			
			if (Physics.Raycast(ray,Mathf.Sqrt(deltaX * deltaX + deltaY * deltaY),collisionMask)) {
				grounded = true;
				deltaY = 0;
			}
		}



		Vector3 finalTransform = new Vector3(deltaX,deltaY);


		transform.Translate (finalTransform,Space.World);
	}

	public void SetCollider(Vector3 size, Vector3 center) {
		collider.size = size;
		collider.center = center;
		
		s = size * colliderScale;
		c = center * colliderScale;
	}

	public void ResetCollider() {
		SetCollider(originalSize,originalCenter);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
