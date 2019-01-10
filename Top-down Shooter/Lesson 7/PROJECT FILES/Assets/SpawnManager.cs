using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public GameObject[] enemies;
	private float spawnTime = 0;

	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnTime >= 3) {
			Spawn ();
			spawnTime = 0;
		} else {
			spawnTime += Time.deltaTime;
		}
	}

	void Spawn(){
		int enemyIndex = Random.Range (0, enemies.Length);
		Instantiate (enemies [enemyIndex], transform.position, transform.rotation);
		winScript.totalEnemies += 1;
	}
}




