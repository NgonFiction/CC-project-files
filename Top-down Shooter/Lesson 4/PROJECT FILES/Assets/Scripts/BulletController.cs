using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public int bulletSpeed;
    private float bulletTime;

    void Start() {
        bulletTime = 0;
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

        if (bulletTime >= 2) {
            Destroy(gameObject);
        }
        else {
            bulletTime += Time.deltaTime;
        }
	}
}

