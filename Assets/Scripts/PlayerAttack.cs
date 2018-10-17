using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {


    Collider2D m_Collider;
    public bool hasAttacked;
    public float timer;
    public float slowTimer;

    // Use this for initialization
    void Start () {
        m_Collider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {



        //attack is Q by default
        if (Input.GetButtonDown("Attack") && hasAttacked == false) {
            m_Collider.enabled = true;
            hasAttacked = true;
        }

        if (m_Collider.enabled == true) {
            timer++;
        }

        if (timer >= 15){
            m_Collider.enabled = false;
            timer++;
        }

        if (timer >= 30) {
            timer = 0;
            hasAttacked = false;
        }



        //slowtime default key is E
        if (Input.GetButton("SlowTime"))
        {
           
            Time.timeScale = 0.5f;
        }
        if (Time.timeScale == 0.5f) {
            slowTimer++;
        }
        if(slowTimer >= 60){

            Time.timeScale = 1.0f;
            slowTimer = 0;
        }


    }
}
