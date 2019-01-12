using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public List<string> inventory = new List<string>(); 

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Key") {
            inventory.Add("Key");
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Gate" && inventory.Contains("Key")) {
            Destroy(other.gameObject);
            inventory.Remove("Key");
        }
    }


}
