using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorcupineTurn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    [SerializeField]
    float _distance;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            _distance = Vector3.Distance(transform.position, player.position);
            Vector3 RelativePos = player.position - transform.position;
            if (_distance <= 23f)
            {
                Quaternion NewRotation = Quaternion.LookRotation(RelativePos, Vector3.up);
                transform.rotation = NewRotation;
            }
        }
        
    }
}
