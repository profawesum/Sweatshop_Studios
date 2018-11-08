
using System;
using System.Collections;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{


    public Transform target01;
    public Transform target02;
    public float speed = 10;


    IEnumerator Start()
    {
        while (true)
        {
            do yield return null; while (MoveTowards(target01));
            do yield return null; while (MoveTowards(target02));
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(255, 64, 0, 0.5f);
        if (target01) Gizmos.DrawLine(transform.position, target01.position);
        if (target02) Gizmos.DrawLine(transform.position, target02.position);
    }


    private bool MoveTowards(Transform target)
    {
        //if (!target)
        //    throw new ArgumentNullException(nameof(target));

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        return transform.position != target.position;
    }
}
