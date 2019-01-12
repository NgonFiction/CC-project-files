using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinePlanterController : MonoBehaviour {

    public GameObject minePrefab;
    public Transform mineSpawn;
    public GameObject explosionPrefab;
    private float rotateTimer;
    public float speed;

	void Start () {
        rotateTimer = 0f;
	}
	
	void Update () {
        if (rotateTimer >= 5) {
            GameObject mine = Instantiate(minePrefab, mineSpawn.position, mineSpawn.rotation);
            Physics.IgnoreCollision(mine.GetComponent<BoxCollider>(), GetComponent<BoxCollider>());
            transform.Rotate(0f, Random.Range(0f, 360f), 0f); 
            rotateTimer = 0;
        }
        else {
            rotateTimer += Time.deltaTime;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

    private void OnCollisionEnter(Collision other) {
        transform.Rotate(0f, 180f, 0f);
        Collider firstCollider = other.contacts[0].thisCollider;
        if (other.gameObject.tag == "Bullet" && firstCollider.gameObject.tag == "Detonator") {
            GameObject[] mines = GameObject.FindGameObjectsWithTag("Mine");
            foreach (GameObject mine in mines) {
                GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(explosion, 1.5f);
                Destroy(mine);
            }
        }
    }
}
