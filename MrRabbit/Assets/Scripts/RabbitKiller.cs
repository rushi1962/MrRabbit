using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitKiller : MonoBehaviour
{
    public GameObject blood;
    public KillPlayer killer;
    void Start()
    {
        killer = GameObject.FindGameObjectWithTag("PlayerKiller").GetComponent<KillPlayer>();
    }
   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            killer.KillThePlayer();
        }
    }
    
}
