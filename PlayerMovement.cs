using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float _speed = 12f;

    Vector3 velocity;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f; //radius of sphere projected by ground check
    public LayerMask groundMask; //to control what objects the groundcheck checks for

    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {   
        //creates a sphere at a given position with a given radius which checks for a given object
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f; //better than 0 just to force the player on ground in case
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * _speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime); // delta y = 1/2 gt2 hence we multiply by time again;
    }
}