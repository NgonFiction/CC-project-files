using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform firePoint;
    public Transform bullet;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")){
			Instantiate(bullet, firePoint.position, firePoint.rotation);
		}
    }
}
	


