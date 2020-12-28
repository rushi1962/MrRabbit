using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject blood;
   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Bug"|| other.gameObject.tag == "Mouse"|| other.gameObject.tag == "Porcupine")
        {
            Instantiate(blood,transform.position,transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
