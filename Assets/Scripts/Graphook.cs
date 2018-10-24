using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphook : MonoBehaviour
{

    DistanceJoint2D joint;
    Vector3 targetpos;
    RaycastHit2D hit;
    public float distance = 10f;
    public LayerMask mask;

    // Use this for initialization
    void Start()
    {
        joint = GetComponent<DistanceJoint2D> ();
        joint.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hello");
            targetpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetpos.z = 0;

            hit = Physics2D.Raycast(transform.position, targetpos - transform.position, distance, mask);

            if (hit.collider != null && hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                Debug.Log("Boom");
                joint.enabled = true;
                joint.connectedBody = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                //joint.connectedAnchor = hit.point - new Vector2(hit.collider.transform.position.x, hit.collider.transform.position.y);
                joint.distance = Vector2.Distance(transform.position, hit.point);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            joint.enabled = false;
        }
    }
}
