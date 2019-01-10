using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float moveVertical = Input.GetAxis ("Vertical") * Time.deltaTime * speed;

		transform.Translate (moveHorizontal, 0, moveVertical);

		// We want a ray that goes from the Main Camera to our cursor!
		Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		// We want the ground plane - the ray will hit to somewhere on this plane
		Plane groundPlane = new Plane(Vector3.up, Vector3.zero); 
		// Vector3.up = (0,1,0) | Vector3.zero = (0,0,0)

		float rayLength; // length of our ray! 

		// if the ground plane detects a ray pointing on it then make the player look at that point on the plane.
		if (groundPlane.Raycast (cameraRay, out rayLength)) {
			Vector3 pointToLook = cameraRay.GetPoint (rayLength);
			Debug.DrawLine (cameraRay.origin , pointToLook, Color.blue);
			transform.LookAt (new Vector3 (pointToLook.x, transform.position.y, pointToLook.z));
		}

		if (transform.position.y < 0) {
			deathScript.isDead = true;
		}
    }
}
	