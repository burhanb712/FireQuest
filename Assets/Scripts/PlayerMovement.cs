using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    //[Header("Ground Check")]
    //public float playerHeight;
   // public LayerMask whatIsGround;
    //bool grounded;

    public Transform orientation;

    float horizontalInput;
    float VerticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void Update()
    {
        //grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        MyInput();
        //if (grounded)
        //    rb.linearDamping = groundDrag;
        //else
        //   rb.linearDamping = 0;
        rb.linearDamping = groundDrag;
        MovePlayer();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        
        horizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
        if (horizontalInput != 0)
            print($"Horizontal Input {horizontalInput}");
        if (VerticalInput != 0)
            print($"Vertical Input {VerticalInput}");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * VerticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

}
