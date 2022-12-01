using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnaNanita{

    public class Walk : MonoBehaviour
    {
        private Rigidbody2D rb;
        [Range(1, 10)]
        public float speed;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            float direccion = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2( direccion * speed , rb.velocity.y);
        }
    }
    }

