using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody2D rb2d;

    Vector2 moveVector;


    // Update is called once per frame
    void Update()
    {

        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + moveVector * moveSpeed * Time.fixedDeltaTime);
    }
}
