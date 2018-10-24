using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {


    public int playerHealth = 1;

	// Update is called once per frame
	void Update () {

        if (playerHealth <= 0) { 
            Application.LoadLevel(Application.loadedLevel);
        }

	}


    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Enemy") {
            playerHealth -= 1;
        }

    }


    void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Enemy") {
            playerHealth -= 1;
        }
    }




}
