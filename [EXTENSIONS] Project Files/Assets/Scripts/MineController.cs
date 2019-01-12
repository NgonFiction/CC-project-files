using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour {

    public int damage;
    public GameObject explosionPrefab;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            other.gameObject.GetComponent<PlayerHealthManager>().TakeDamage(damage);
            Destroy(gameObject);
            Destroy(explosion, 1.5f);
        }
    }
}
