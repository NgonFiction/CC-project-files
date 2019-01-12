using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public int bulletSpeed;

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
