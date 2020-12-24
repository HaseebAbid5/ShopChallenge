using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Control every player action
public class PlayerActions : MonoBehaviour {

    public float speed = 5f,
                rayDistance = 1.5f;

    public bool talking = false, 
                action = false;

    public Vector3 offset;

    public Animator anim;
    public Rigidbody2D rb2d;
    public SpriteRenderer shirt;
    public Inventory inventory;

    Vector2 movement, direction;
    RaycastHit2D hit;

    // Update is called once per frame
    void Update () {

        shirt.sprite = inventory.GetCurrentShirt();
    
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");  //Movement vectors

        if (movement != Vector2.zero)
            direction = movement;

        if (talking)
            hit = Physics2D.Raycast(transform.position, Vector2.zero, 0f); //cast purposfully weak raycast for null result
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
                hit = Physics2D.Raycast(transform.position + offset, direction, rayDistance); //proper raycast
        }
            

        if (movement != Vector2.zero)
            anim.SetBool("IsMoving", true);
        else
            anim.SetBool("IsMoving", false);  //for animator

	}

    private void FixedUpdate()
    {

        //Moves player
        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);


        //If player is close to the big screen then begin the convo
        if (hit.collider != null)
        {
                if (hit.collider.tag.Equals("Sign") && !talking)
                {
                    talking = true;
                    hit.collider.GetComponent<DialogueTrigger>().TriggerDialogue();
                }
        }

    }


    //Is called when convo is over
    public void DoneTalking()
    {
        talking = false;
    }

}
