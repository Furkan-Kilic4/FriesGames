using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    SoundManager soundManagerScript;
    LevelManagerScript levelManagerScript;
    UIManager UIManagerScript;
    private Rigidbody2D rb;
    SpriteRenderer playerRenderer;
    private float horizontalMove;
    [SerializeField] private float playerSpeed = 10f;
    float fallScreenBounds = -6f;

    void Start()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManagerScript>();
        UIManagerScript = GameObject.Find("UI Manager").GetComponent<UIManager>(); 
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
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
            soundManagerScript.Fall();
            Destroy(gameObject);
            levelManagerScript.RespawnPlayer();
            UIManagerScript.GetComponent<Canvas>().enabled = true;
        }
    }
}
