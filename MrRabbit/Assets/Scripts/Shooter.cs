using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    public float power = 10.0f;
    public Animator animator;
    public GameObject parentObject;
    // Reference to AudioClip to play
    public AudioClip shootSFX;
    public Transform Player;
    public float distance;
    [SerializeField]
    float _current, _delay;
    void Start()
    {
        Player= GameObject.FindGameObjectWithTag("Player").transform;
        _current = _delay = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player!=null)
        {
            distance = Vector3.Distance(transform.position,Player.position);
            if(distance<=25f)
            {
                _current -= Time.deltaTime;
                if(parentObject.tag=="Porcupine")
                {
                    animator.SetBool("defence",true);
                }
                if(_current<=0f)
                {
                    shoot();
                    _current = _delay;
                }
            }
        }
    }
    void shoot()
    {
        if (parentObject.tag == "Mouse")
        {
            animator.SetTrigger("Attack");
        }
        GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;
        if (!newProjectile.GetComponent<Rigidbody>())
        {
            newProjectile.AddComponent<Rigidbody>();
        }
        // Apply force to the newProjectile's Rigidbody component if it has one
        newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);
        print("Within range");
       
        if (shootSFX)
        {
            if (newProjectile.GetComponent<AudioSource>())
            { // the projectile has an AudioSource component
              // play the sound clip through the AudioSource component on the gameobject.
              // note: The audio will travel with the gameobject.
                newProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
            }
            else
            {
                // dynamically create a new gameObject with an AudioSource
                // this automatically destroys itself once the audio is done
                AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);
            }
        }
    }
}
