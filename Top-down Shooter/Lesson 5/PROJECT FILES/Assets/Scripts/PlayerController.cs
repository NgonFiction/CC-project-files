using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    private Ray cameraRay;
    // The ray will hit to somewhere on this plane
    public Plane groundPlane;
    
    void Start() {
        // Vector3.up = (0,1,0) | Vector3.zero = (0,0,0)
        groundPlane = new Plane(Vector3.up, Vector3.zero);
    }

    // Update is called once per frame
    private void FixedUpdate() {
        // Player Movement
        float moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(moveHorizontal, 0, moveVertical);

        // A ray from the Main Camera to our cursor
        cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float rayLength;
        if (groundPlane.Raycast(cameraRay, out rayLength)) {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
