using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallEnemy : MonoBehaviour {

    public bool inRange = false;
    public GameObject fireball;
    public Rigidbody projectile;
    public int Hp;

	// Update is called once per frame
	void Update () {

        //checks value of hp
        if (Hp <= 0) {
            //destroys the enemy
            Destroy(gameObject);
        }

        if (inRange == true)
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player")
        {
            inRange = true;
        }

        if (other.tag == "PlayerWeapon") {
            Hp -= 1;
        }
    }

    void OnTriggerExit2D(Collider2D other) {

        if (other.tag == "Player")
        {
            inRange = false;
        }
    }
}
