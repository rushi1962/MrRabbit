using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakOnEnter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parentObject;
    public GameObject particles;
   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {

            Invoke("destroyAfterDelay",1f);
        }
    }
    void destroyAfterDelay()
    {
        Instantiate(particles, transform.position, transform.rotation);
        Destroy(parentObject);
    }
}
