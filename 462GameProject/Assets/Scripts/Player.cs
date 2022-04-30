using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

<<<<<<< Updated upstream
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
=======

    Vector2 movement;
>>>>>>> Stashed changes

    private void Start() {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    
    private void FixedUpdate() {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // Reset moveDelta
        moveDelta = new Vector3(x, y, 0);

        // Swap Sprite Direction toward direction
        if(moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if(moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        // Make sure we can move this direction by casting a box, if null we cna move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if(hit.collider == null) {
            // Movement
            transform.Translate(0, moveDelta.y * (Time.deltaTime*2), 0);
        }

        // Make sure we can move this direction by casting a box, if null we cna move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if(hit.collider == null) {
            // Movement
            transform.Translate(moveDelta.x * (Time.deltaTime*2), 0, 0);
        }
        

    }

<<<<<<< Updated upstream
=======
    
>>>>>>> Stashed changes
}
