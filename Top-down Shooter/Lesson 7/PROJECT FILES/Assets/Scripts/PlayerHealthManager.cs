using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

	public int currentHealth;
	
	public void TakeDamage(int damage){
		currentHealth -= damage;
		//print ("Player took " + damage + " damage! Player health: " + currentHealth);
		if (currentHealth <= 0) {
			deathScript.isDead = true;
			Time.timeScale = 0;
		}
	}
}

/* 
			Time.timeScale = 0;*/