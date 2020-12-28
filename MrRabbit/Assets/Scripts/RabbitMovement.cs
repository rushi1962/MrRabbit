using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public float speed = 6f;
    public float directionFloat = 0f;
    public float TurningSmoothTime = 0.1f;
    float TurnSmoothVelocity;
    public Animator PlayerAnimation;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public Joystick joystick;
    Vector3 velocity;
    public float height = 15f;
    bool isGrounded, run;
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        run = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = joystick.Horizontal;
        Vector3 direction = new Vector3(0f, 0f, horizontal).normalized;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (direction.magnitude >= 0.1f)
        {
            float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg ;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref TurnSmoothVelocity, TurningSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 movDir = Quaternion.Euler(0f, TargetAngle, 0f) * Vector3.forward;
            controller.Move(movDir.normalized * speed * Time.deltaTime);

            run = true;

        }
        else
        {

            run = false;
        }
        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
       /* if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jump();

        }*/
        PlayerAnimation.SetBool("isGrounded", isGrounded);
        PlayerAnimation.SetBool("run", run);
    }
    public void jump()
    {
        if(isGrounded)
        {
            velocity.y = Mathf.Sqrt(-2f * height * gravity);
        }
       
    }
    
}
