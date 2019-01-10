using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public int damage;
	public int bulletSpeed;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * bulletSpeed * Time.deltaTime);
    }

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Enemy"){
			print ("Bullet collided with an enemy!");
			other.gameObject.GetComponent<EnemyHealthManager>().TakeDamage (damage); 
			Destroy (gameObject);
		}
    }
}


/*if (Vector3.Distance (firePoint, transform.position) >= maxDistanc) {
			//print ("DISTANCE: " + Vector3.Distance (firePoint, transform.position));
			Destroy(transform.gameObject);
		}*/

/*




*/