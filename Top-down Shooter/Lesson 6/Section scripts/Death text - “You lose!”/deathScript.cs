using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathScript : MonoBehaviour {

	public static bool isDead = false;
	Text deathText;

	void Start () {
		deathText = GetComponent<Text> ();
	}

	void Update () {
		if (isDead == true) {
			deathText.enabled = true;
		}

	}
}

//public Button endgameButton;
//endgameButton.gameObject.SetActive (true);