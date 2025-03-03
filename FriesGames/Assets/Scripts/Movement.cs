using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    SpriteRenderer playerRenderer;
    private float horizontalMove;
    [SerializeField] private float playerSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        PlayerMovement();
        FlipWithRenderer();
    }

    void PlayerMovement()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMove * playerSpeed, rb.velocity.y);
    }

    private void FlipWithRenderer()
    {
        if (horizontalMove > 0)
        {
            playerRenderer.flipX = false;
        }

        else if (horizontalMove < 0)
        {
            playerRenderer.flipX = true;
        }
    }
}
