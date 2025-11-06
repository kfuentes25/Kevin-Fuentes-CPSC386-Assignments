using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed = 12f;
    [SerializeField] private Animator _animator;

    private Vector2 movement;
    private float xPosLastFrame;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        HandleMovement();

    }

    private void HandleMovement(){
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
        if (input != 0){
            _animator.SetBool("isRunning", true);
        }
        else{
            _animator.SetBool("isRunning", false);
        }
    }
}
