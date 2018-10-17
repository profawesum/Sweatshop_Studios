using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {


    public int playerHealth = 3;

	// Update is called once per frame
	void Update () {

        if (playerHealth <= 0) { 
            Application.LoadLevel(Application.loadedLevel);
        }

	}

    void OnTriggerEnter2d(Collider2D other) {

        if (other.tag == "Enemy") {
            playerHealth -= 1;
        }

    }




}
