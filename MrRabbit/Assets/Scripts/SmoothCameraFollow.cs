using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    public Vector3 OffSet;
    public float dampning=0.0125f;
   

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Target!=null)
        {
            Vector3 DesiredPosition = Target.position + OffSet;
            Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, dampning);
            transform.position = SmoothPosition;
            transform.LookAt(Target);

        }
        
    }
}
