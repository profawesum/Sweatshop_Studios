using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {


    Collider m_Collider;
    public float timer;

    // Use this for initialization
    void Start () {
        m_Collider = GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {



        //attack is Q by default
        if (Input.GetButton("Attack")) {

            m_Collider.enabled = false;

        }
        if (m_Collider.enabled == false) {

            timer++;
        }
        if (timer == 15) {

            m_Collider.enabled = true;

        }




    }
}
