using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public RabbitMovement rabbit;
    public RabbitShooter shooter;
    public float RabbitDirection=0f;
    public void jumpOnClick()
    {
        rabbit.jump();
        
    }
    public void shootOnClick()
    {
        shooter.shoot();
    }
   
}
