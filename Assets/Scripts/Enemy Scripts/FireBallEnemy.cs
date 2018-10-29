using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallEnemy : MonoBehaviour {

    public bool inRange = false;
    public GameObject fireball;
    public Rigidbody projectile;
    public float bulletSpeed;



    public int timeDelay;
    public int timer;

	// Update is called once per frame
	void Update () {


        timer++;

        //checks to see if the player is in range
        if (inRange == true)
        {
            if (timer > timeDelay)
            {
                //create a clone of the rigidbody
                Rigidbody clone;
                //instantiate the clone
                clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
                //give the clone speed
                clone.velocity = transform.TransformDirection(Vector3.left * bulletSpeed);
                //set timer to 0
                timer = 0;
            }
        }
    }



    //checks trigger enter
    void OnTriggerEnter2D(Collider2D other) {

        //checks to see if the player has collided
        if (other.tag == "Player")
        {
            //set inRange to true
            inRange = true;
        }


    }


    //Checks trigger exit
    void OnTriggerExit2D(Collider2D other) {

        //checks to see if the player is leaving trigger box
        if (other.tag == "Player")
        {
            // set inRange to false;
            inRange = false;
        }
    }
}
