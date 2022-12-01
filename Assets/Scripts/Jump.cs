using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    private Rigidbody2D rb;
    public float fallMultiplayer = 2.5f;
    public float lowJumpMultiplayer = 2f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        bool jump = Input.GetButton("Jump");
        if (jump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += new Vector2(0, Physics2D.gravity.y * (fallMultiplayer - 1) * Time.deltaTime * 1) ;
        }
        else if (rb.velocity.y > 0 && !jump)
        {
            rb.velocity += new Vector2(0, Physics2D.gravity.y * (fallMultiplayer - 1) * Time.deltaTime * 1) ;
        }
    }
}
