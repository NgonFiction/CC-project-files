using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform[] firePoints;
    public GameObject bulletPrefab;
	
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
            int i;
            for (i = 0; i < firePoints.Length; i++) {
                GameObject bullet = Instantiate(bulletPrefab, firePoints[i].position, firePoints[i].rotation);
                Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
                Destroy(bullet, 3f);
            }
        }
	}
}
