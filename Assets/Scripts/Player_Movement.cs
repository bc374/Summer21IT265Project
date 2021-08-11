using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump;


    private Rigidbody2D body;
    private Animator anim;
    private bool Grounded;
    private float horizontalInput;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        // controls player's movement on x-axis
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        // controls character's flip in directions
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.82f, 0.8f, 1f);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.8f, 0.8f, 1f);

        // Space button controls jump movement 
        if (Input.GetKey(KeyCode.W) && Grounded)
            Jump();

        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("Grounded", Grounded);
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        Grounded = false;
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Grounded = true;
    }

    public bool charaAttack()
    {
        return horizontalInput == 0;
    }

}
