using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

	public int currentHealth;

	public void TakeDamage(int damage){
		currentHealth -= damage;
		print ("Enemy took " + damage + " damage! Enemy health: " + currentHealth);
		if (currentHealth <= 0) {
			Destroy (gameObject);
			scoreScript.scoreValue += 1;
		}
	}
}

/*
 * 
 * 		 
		if (currentHealth <= 0) {
			Destroy (gameObject);

		}
*/