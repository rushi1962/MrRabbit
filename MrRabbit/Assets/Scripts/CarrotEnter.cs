using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotEnter : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            GameManager.gm.Carrots += 1;
            Destroy(gameObject);
        }
       
    }
}
