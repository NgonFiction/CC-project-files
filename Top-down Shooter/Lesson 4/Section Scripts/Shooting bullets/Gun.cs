using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
            Destroy(bullet, 3f);
        }
	}
}
