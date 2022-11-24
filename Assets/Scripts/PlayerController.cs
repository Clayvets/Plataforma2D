using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnaNanita{

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rb.velocity = new Vector2(-10, rb.velocity.y);
        }
    }
}
}
