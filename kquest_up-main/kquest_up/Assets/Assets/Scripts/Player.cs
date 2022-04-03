using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    public Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    public Animator animator;
   
    void Update()
    {
        moveInput = new Vector2 (joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * speed;
        animator.SetFloat("Horizontal", joystick.Horizontal);
        animator.SetFloat("Vertical", joystick.Vertical);
        animator.SetFloat("Speed", moveVelocity.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    } 
}
