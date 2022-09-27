using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator playerAni;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && DATA.isDie == false && DATA.esc == false)
        {
            Vector2 moveRight = new Vector2(DATA.moveSpeed * Time.deltaTime, 0);
            transform.localScale = new Vector2(1, 1);
            playerAni.SetBool("Move", true);
            transform.Translate(moveRight);
            /* (Input.GetKeyDown(KeyCode.Z))
            {
                playerAni.SetBool("Move", false);
                playerAni.SetBool("Jump",true);
                rb.velocity = Vector2.up * DATA.jumpPower;
            }*/
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && DATA.isDie == false && DATA.esc == false)
        {
            Vector2 moveLeft = new Vector2(-DATA.moveSpeed * Time.deltaTime, 0);
            transform.localScale = new Vector2(-1, 1);
            playerAni.SetBool("Move", true);
            transform.Translate(moveLeft);
            /*if (Input.GetKeyDown(KeyCode.Z))
            {
                playerAni.SetBool("Move", false);
                playerAni.SetBool("Jump", true);
                rb.velocity = Vector2.up * DATA.jumpPower;
            }*/
        }
        /*if (Input.GetKeyDown(KeyCode.Z))
        {
            playerAni.SetBool("Move", false);
            playerAni.SetBool("Jump", true);
            rb.velocity = Vector2.up * DATA.jumpPower;
        }*/
        else
        {
            playerAni.SetBool("Move", false);
            playerAni.SetBool("Jump", false);
        }
    }
}
