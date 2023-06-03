using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10f;

    Vector3 velocity;
    [SerializeField] float gravity = -9.81f;

    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 0.4f;
    public LayerMask groundMask;
    [SerializeField] float jumpHeight = 2f;
    bool isGrounded;

    void Start()
    {
        
    }

    
    void Update()
    {
        GroundCheck();       
        PlayerInput();           
        Jump();          
    }

    void GroundCheck()
    {
         isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }

    void PlayerInput()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move =  transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)   
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        velocity.y += gravity * Time.deltaTime; 
    }
}
