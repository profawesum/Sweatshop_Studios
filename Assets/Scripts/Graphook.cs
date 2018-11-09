using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphook : MonoBehaviour
{
    public LineRenderer line;
    DistanceJoint2D joint;
    Vector3 targetPos;
    RaycastHit2D hit;
    public float distance = 10f;
    public LayerMask mask;
    public float step = 0.02f;
    bool sound = false;

    // Use this for initialization
    void Start()
    {
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        line.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (joint.distance > .5f)
            joint.distance -= step;
        else
        {

            joint.enabled = false;

        }


        if (Input.GetMouseButtonDown(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;

            hit = Physics2D.CircleCast(transform.position,2, targetPos - transform.position, distance, mask);

            if (hit.collider != null && hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)

            {
              
                FindObjectOfType<AudioManager>().Play("GrapplingHookv2");
                joint.enabled = true;
                //Debug.Log (hit.point - new Vector2(hit.collider.transform.position.x,hit.collider.transform.position.y);
                Vector2 connectPoint = hit.point - new Vector2(hit.collider.transform.position.x, hit.collider.transform.position.y);
                connectPoint.x = connectPoint.x / hit.collider.transform.localScale.x;
                connectPoint.y = connectPoint.y / hit.collider.transform.localScale.y;
                Debug.Log(connectPoint);
                joint.connectedAnchor = connectPoint;

                joint.connectedBody = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                joint.connectedAnchor = hit.point - new Vector2(hit.collider.transform.position.x,hit.collider.transform.position.y);
                joint.connectedAnchor = hit.point - new Vector2(hit.collider.transform.position.x, hit.collider.transform.position.y);
                joint.distance = Vector2.Distance(transform.position, hit.point);

                line.enabled = true;
                line.SetPosition(0, transform.position);
                line.SetPosition(1, hit.point);

               // line.GetComponent<roperatio>().grabPos = hit.point;


            }
        }
        if (Input.GetMouseButton(0))
        {

            line.SetPosition(0, transform.position);
        }


        if (Input.GetMouseButtonUp(0))
        {
            joint.enabled = false;
            line.enabled = false;
        }


    }
}






