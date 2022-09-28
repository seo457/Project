using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator playerAni;
    Rigidbody2D rb;
    SpriteRenderer sr;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        DATA.playerDie = false;
        playerAni.SetBool("Die", false);
    }

    private void Update()
    {
        // jump
        if (Input.GetButtonDown("Jump") && !playerAni.GetBool("Jump") && DATA.playerDie == false)
        {
            rb.AddForce(Vector2.up * DATA.jumpPower, ForceMode2D.Impulse);
            playerAni.SetBool("Jump", true);
        }

        // move
        if (Input.GetButtonUp("Horizontal") && DATA.playerDie == false)
        {
            rb.velocity = new Vector2(rb.velocity.normalized.x * 0.5f, rb.velocity.y);
        }

        // turn
        if (Input.GetButton("Horizontal") && DATA.playerDie == false)
        {
            sr.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }

        // move animation
        if (rb.velocity.normalized.x == 0)
        {
            playerAni.SetBool("Move", false);
        }
        else
        {
            playerAni.SetBool("Move", true);
        }

        // jump animation
        Debug.DrawRay(rb.position, Vector3.down, new Color(0, 1, 0));
        if (rb.velocity.y < 0)
        {
            RaycastHit2D ground = Physics2D.Raycast(transform.position, Vector3.down, 1, LayerMask.GetMask("Ground"));
            if (ground.collider != null)
            {
                if (ground.distance < 0.5f)
                {
                    playerAni.SetBool("Jump", false);
                }
            }
        }

        // die
        if (DATA.playerDie == true)
        {
            playerAni.SetBool("Die", true);
        }
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rb.velocity.x > DATA.moveSpeed)
        {
            rb.velocity = new Vector2(DATA.moveSpeed, rb.velocity.y);   // move right
        }
        else if (rb.velocity.x < -DATA.moveSpeed)
        {
            rb.velocity = new Vector2(-DATA.moveSpeed, rb.velocity.y);  // move left
        }
    }
}
