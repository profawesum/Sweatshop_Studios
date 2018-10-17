using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {


    Collider2D m_Collider;
    public bool hasAttacked;
    public float timer;

    // Use this for initialization
    void Start () {
        m_Collider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {



        //attack is Q by default
        if (Input.GetButtonDown("Attack")) {
            m_Collider.enabled = true;

        }
        if (m_Collider.enabled == true) {
            timer++;
        }
        if (timer == 5)
        {
            m_Collider.enabled = false;
            timer = 0;

        }
    }
}
