using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    private int currentWeapon;
    private int selectedWeapon;

    void Start() {
        // First weapon is initially the first child of Weapon Holder 
        // First weapon's index is 0
        selectedWeapon = 0;
        currentWeapon = 0;
    }

    void Update() {
        // Scroll mousewheel forward to switch to next weapon in weapon list
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
            if (selectedWeapon >= transform.childCount - 1) {
                selectedWeapon = 0;
            }
            else {
                selectedWeapon++;
            }
        }

        // Scroll mousewheel backward to switch to previous weapon in weapon list
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
            if (selectedWeapon <= 0) {
                selectedWeapon = transform.childCount - 1;
            }
            else {
                selectedWeapon--;
            }
        }

        // Press '1' key to switch current weapon to first gun
        if (Input.GetKeyDown(KeyCode.Alpha1) && transform.childCount >= 1) {
            selectedWeapon = 0;
        }
        // Press '2' key to switch current weapon to second gun
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2) {
            selectedWeapon = 1;
        }
        // Press '3' key to switch current weapon to third gun
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3) {
            selectedWeapon = 2;
        }
        // Press '4' key to switch current weapon to third gun
        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4) {
            selectedWeapon = 3;
        }

        // Update current weapon to selected weapon
        if (selectedWeapon != currentWeapon) {
            transform.GetChild(currentWeapon).gameObject.SetActive(false);
            transform.GetChild(selectedWeapon).gameObject.SetActive(true);
            currentWeapon = selectedWeapon;
        }
    }
}