﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerBulletController : MonoBehaviour {

    public int bulletSpeed;
    public int damage;

    void Update() {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerHealthManager>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
