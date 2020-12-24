using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody2D rb2d;
    public Animator anim;

    Vector2 moveVector;


    // Update is called once per frame
    void Update()
    {

        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        if (moveVector != Vector2.zero)
            anim.SetBool("IsMoving", true);
        else
            anim.SetBool("IsMoving", false);

    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + moveVector * moveSpeed * Time.fixedDeltaTime);
    }
}
