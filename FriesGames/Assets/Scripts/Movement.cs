using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMove;
    [SerializeField] private float playerSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMove * playerSpeed, rb.velocity.y);
    }
}
