using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    LevelManagerScript levelManagerScript;
    private Rigidbody2D rb;
    SpriteRenderer playerRenderer;
    private float horizontalMove;
    [SerializeField] private float playerSpeed = 10f;
    float fallScreenBounds = -6f;

    void Start()
    {
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManagerScript>();
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
        Invoke("SpawnCharacterAtTime", 3f);
    }

    
    void Update()
    {
        PlayerMovement();
        FlipWithRenderer();
        DestroyPlayer();
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

    void DestroyPlayer()
    {
        if (transform.position.y < fallScreenBounds)
        {
            Destroy(gameObject);
            levelManagerScript.RespawnPlayer();
            Invoke("SpawnCharacterAtTime", 3f);
        }
    }
}
