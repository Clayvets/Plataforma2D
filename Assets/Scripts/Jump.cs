using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    private Rigidbody2D rb;
    public float fallMultiplayer = 2.5f;
    public float lowJumpMultiplayer = 2f;
    public int count;
    bool canJump = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        bool jump = Input.GetButtonDown("Jump");
        if (canJump && count <= 1)
        {
            if (jump)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
                count ++;
                
            }
        }
        
        if (rb.velocity.y < 0)
        {
            rb.velocity += new Vector2(0, Physics2D.gravity.y * (fallMultiplayer - 1) * Time.deltaTime * 1); //REVISAR FUNCIONAMIENTO
        }
        else if (rb.velocity.y > 0 && !jump)
        {
            rb.velocity += new Vector2(0, Physics2D.gravity.y * (fallMultiplayer - 1) * Time.deltaTime * 1);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            count = 0;
        }
    } 
    
}
