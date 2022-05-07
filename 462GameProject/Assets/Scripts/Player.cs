using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{ 
    public Rigidbody2D rb;
    public float moveSpeed = 3f;
    public Animator animator;

    Vector2 movement;
    // private Vector3 movePlayer;

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate() {
        // movePlayer = new Vector3(movement.x, movement.y, 0);
        // if(movePlayer.x > 0) {
        //     transform.localScale - Vector3.one;
        // } else if (movePlayer.x < 0) {
        //     transform.localScale = new Vector3(-1, 1, 1);
        // }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
