using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Ray cameraRay;
    Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(moveHorizontal, 0, moveVertical);
    }
