using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winScript : MonoBehaviour {

	Text winText;
	public static int totalEnemies = 0; // to keep track of how many enemies in total there are 

	void Start () {
		winText = GetComponent<Text> ();
	}

	void Update () {
		if (scoreScript.scoreValue == totalEnemies) {
			winText.enabled = true;
            Time.timeScale = 0;
		}
	}
}
