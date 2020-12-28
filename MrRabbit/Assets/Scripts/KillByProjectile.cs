using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillByProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LinkedObject,Blood;
   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Projectile")
        {
            Instantiate(Blood,LinkedObject.transform.position,LinkedObject.transform.rotation);
            Destroy(LinkedObject);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
