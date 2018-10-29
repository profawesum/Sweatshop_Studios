using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeAttack : MonoBehaviour {

    Collider2D m_Collider;
    public bool inRange = false;
    public bool hasAttacked;
    public float timer;

	// Use this for initialization
	void Start ()
    {
        m_Collider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer++;
        
		if(inRange == true)
        {
            if (timer > 30) 
            {
                m_Collider.enabled = false;
            }
            if (timer > 60)
            {
                m_Collider.enabled = true;

                timer = 0;
            }
        }
	}
    //checks trigger enter
    void OnTriggerEnter2D(Collider2D other)
    {

        //check if player collided
        if(other.tag == "Player")
        {
            inRange = true;
        }
    }
    //Checks if player has exited
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            inRange = false;
        }
    }
}
