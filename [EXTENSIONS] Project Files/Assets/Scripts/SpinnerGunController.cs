using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerGunController : MonoBehaviour {

    private float shootTimer;
    public Transform firePoint;
    public GameObject bulletPrefab;

	void Start () {
        shootTimer = 0f;
	}
	
	void Update () {
		if (shootTimer >= 2) {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Destroy(bullet, 10f);
            shootTimer = 0;
        }
        else {
            shootTimer += Time.deltaTime;
        }
	}
}

