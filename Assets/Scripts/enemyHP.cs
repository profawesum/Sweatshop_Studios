using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     


    }



    void OnTriggerEnter2D(Collider2D other)
    {


        //checks to see if playerWeapon 
        if (other.tag == "PlayerWeapon")
        {   //destroys the enemy
            Destroy(gameObject);

        }
    }
}
