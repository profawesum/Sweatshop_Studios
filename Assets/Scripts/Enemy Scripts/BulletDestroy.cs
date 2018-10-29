using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{

    public int destroyTime;

    public int destroyTimer;

    // Update is called once per frame
    void Update()
    {

        destroyTimer++;


        if (destroyTimer > destroyTime)
        {

            Destroy(gameObject);
        }


    }
}
