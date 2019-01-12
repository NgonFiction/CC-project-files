using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    public int damage;
    private bool isAttacking = false;
    private float contactTime = 0;
    private GameObject thePlayer;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerHealthManager>().TakeDamage(damage);
            isAttacking = true;
            thePlayer = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other) {
        isAttacking = false;
        contactTime = 0;
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerHealthManager>().TakeDamage(damage);
            isAttacking = true;
            thePlayer = other.gameObject;
        }    
    }

    void OnCollisionExit(Collision other) {
        isAttacking = false;
        contactTime = 0;
    }

    void Update() {
        if (isAttacking) {
            if (contactTime >= 1) {
                thePlayer.GetComponent<PlayerHealthManager>().TakeDamage(damage);
                contactTime = 0;
            }
            else {
                contactTime += Time.deltaTime;
            }
        }    
    }
}
