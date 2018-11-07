using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Fall : MonoBehaviour {
    public float movementSpeed;
    public GameObject hand;
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
       
        if(!hand == GameObject.Find("Disapperaing Platfrom BAsre"))
        {
            transform.Postion(transform.down * Time.deltaTime * movementSpeed);
        }
	}
}
