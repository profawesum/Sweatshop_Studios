using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour {


    public float Hp = 2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
        
        
        //checks value of hp
        if (Hp <= 0)
        {
            //destroys the enemy
            Destroy(gameObject);
        }



    }

    void OnTriggerEnter2D(Collider2D other) {


        //checks to see if playerWeapon 
        if (other.tag == "PlayerWeapon")
        {
            //reduce Hp by 1
            Hp -= 1;
        }
    }
}
