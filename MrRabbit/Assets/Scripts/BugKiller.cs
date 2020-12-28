using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugKiller : MonoBehaviour
{
    public GameObject Bug;
    public GameObject BugBlood,Sphere;
   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Instantiate(BugBlood, Sphere.transform.position, Sphere.transform.rotation);
            Destroy(Bug);
        }
    }
}
