using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private float horizontal;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Animator _animator;

    private Vector2 movement;
    private float xPosLastFrame;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Flip();
        HandleMovement();

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void HandleMovement()
    {
        float inputMovement = Input.GetAxis("Horizontal");
        movement.x = inputMovement * speed * Time.deltaTime;
        transform.Translate(movement);

        if (inputMovement != 0){
            _animator.SetBool("isRunning", true);
        }
        else{
            _animator.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded()) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
            _animator.SetBool("isJumping", true);
            // Play sound effect for Jump
        }        
        else {
            _animator.SetBool("isJumping", false);
        } 
        // if (Input.GetButtonDown("Jump") && rb.linearVelocity.y > 0f) {
        //     rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        //     _animator.SetBool("isJumping", true);
        // }
    }
}
