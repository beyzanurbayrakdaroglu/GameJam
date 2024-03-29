using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 10f;
    public float gravity = -12f;
    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    void Update()
    {
        isGrounded=Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       
        Vector3 move = transform.right * x + transform.forward * z;
        
        characterController.Move(move * speed * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;
        
        characterController.Move(velocity*Time.deltaTime);


    }
}
