using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnaNanita{

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        float direccion = Input.GetAxisRaw("Horizontal");
        float salto = Input.GetAxisRaw("Vertical");
        
        if (direccion != 0f)
        {
            rb.velocity = new Vector2( direccion * 10f , rb.velocity.y);
        }
        
        if (salto != 0f)
        {
            rb.velocity = new Vector2( rb.velocity.x, salto * 10);
        }
        
    }
    
}
}
