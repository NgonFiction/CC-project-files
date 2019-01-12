using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBotController : MonoBehaviour {

    private int direction;
    public int speed;

	void Start () {
        direction = 1;
	}
	
	void Update () {
        transform.Translate(Vector3.forward * direction * speed * Time.deltaTime);
	}

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Wall") {
            direction *= -1;
        }
    }
}

