using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{      
    public float walkSpeed = 5f;
    public float moveSpeed;
    public float sprintSpeed = 10f;
    public float jumpStrength = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public int NegativeGravityStrength = -8;
    public int PositiveGravityStrength = 8;



    private Rigidbody2D rb;
    private bool isGrounded;
    private const float groundCheckRadius = 0.2f;
    private bool normalGravity = true;
    private bool isJumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()

    {

        // STUFF FOR MOVEMENT
        float horizontalInput = Input.GetAxis("Horizontal");


        Vector2 movement = new Vector2(horizontalInput, 0).normalized;

        rb.velocity = movement * moveSpeed;

        // // Rotation testing
        // if (movement != Vector2.zero)
        // {
        //     float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
        //     transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // }


       //STUFF FOR JUMPING
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);


        // // if (isGrounded && Input.GetButtonDown("Jump"))
        // if (Input.GetButtonDown("Jump"))
        // {
        //     if(normalGravity){
        //         rb.gravityScale = NegativeGravityStrength;
        //         normalGravity = false;
        //     }

        //     else {
        //         rb.gravityScale = PositiveGravityStrength;
        //         normalGravity = true;
        //     }
            
       
        // }


      if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            // Reverse the gravity
            rb.gravityScale = NegativeGravityStrength;
            //Wait x amount of seconds
            StartCoroutine(ReturnGravity());

        }
    IEnumerator ReturnGravity()
    {
    yield return new WaitForSeconds(1);
    // Return gravity to normal
        rb.gravityScale = PositiveGravityStrength;
        isJumping = false;
    }


    }
    // private void Sprint()
    // {
    //     moveSpeed = sprintSpeed;
    // }
}
