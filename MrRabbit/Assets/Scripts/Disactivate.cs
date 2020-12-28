using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disactivate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platform;
    public float delay = 5f;
    public float current;
    public bool Activate;
    void Start()
    {
        current=delay;
        
       // Activate = true;
    }

    // Update is called once per frame
   void Update()
    {
        
        
            current -= Time.deltaTime;
            if(current<=0f)
            {
                if(Activate==true)
                {
                    Activate = false;
                    current = delay;
                }
                else
                {
                    Activate = true;
                    current = delay;
                }
                platform.SetActive(Activate);
            }
        
    }
}
