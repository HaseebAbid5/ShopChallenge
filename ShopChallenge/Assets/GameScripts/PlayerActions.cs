using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

    public float speed = 5f,
                rayDistance = 1.5f;

    public bool talking = false, 
                action = false;

    public Vector3 offset;

    public Animator anim;
    public Rigidbody2D rb2d;

    Vector2 movement, direction;
    RaycastHit2D hit;

	// Update is called once per frame
	void Update () {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector2.zero)
            direction = movement;

        if (talking)
            hit = Physics2D.Raycast(transform.position, Vector2.zero, 0f);
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
                hit = Physics2D.Raycast(transform.position + offset, direction, rayDistance);
        }
            

        if (movement != Vector2.zero)
            anim.SetBool("IsMoving", true);
        else
            anim.SetBool("IsMoving", false);

	}

    private void FixedUpdate()
    {

        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);

        if (hit.collider != null)
        {
                if (hit.collider.tag.Equals("Sign") && !talking)
                {
                    talking = true;
                    hit.collider.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
        }

    }


    public void DoneTalking()
    {
        talking = false;
    }

}
