using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour {

	Text healthText;
	public GameObject player;
	private int playerHealth;

	void Start () {
		healthText = GetComponent<Text> ();
	}

	void Update () {
		playerHealth = player.GetComponent<PlayerHealthManager> ().currentHealth;
		if (playerHealth >= 0) {
			healthText.text = "Health: " + playerHealth;
		} 
		else {
			healthText.text = "Health: 0";
		}
	}
}
