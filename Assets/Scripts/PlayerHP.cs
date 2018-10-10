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

    void OnCollsionEnter2D(Collision2D other) {

        //if (other == "Enemy") {

        //    playerHealth -= 1;
        //}

    }




}
