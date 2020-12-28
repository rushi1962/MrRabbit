using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugMover : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PointA, PointB, NewTarget;
   // public Rigidbody rb;
    public float MoveSpeed = 5f;
    void Start()
    {
        NewTarget = PointA;
       // rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z<=NewTarget.position.z+8f&& transform.position.z>= NewTarget.position.z - 8f)
        {
            if(NewTarget==PointA)
            {
                NewTarget = PointB;
            }
            else
            {
                NewTarget = PointA;
            }
        }
        Vector3 RelativePos = NewTarget.position - transform.position;
        Quaternion NewRotation = Quaternion.LookRotation(RelativePos, Vector3.up);
        transform.rotation = NewRotation;
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
}
