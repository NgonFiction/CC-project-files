using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int moveSpeed;
    private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(thePlayer.transform.position);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
}
