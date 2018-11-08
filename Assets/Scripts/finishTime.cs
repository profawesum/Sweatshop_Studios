using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishTime : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Timer Finished");
        GameObject.Find("CharacterRobotBoy").SendMessage("Finnish");
    }
	
}
