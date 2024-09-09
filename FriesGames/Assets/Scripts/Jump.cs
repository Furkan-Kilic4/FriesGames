using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 vUp = new Vector2(0, 1);
    [SerializeField] private float jumpAmount;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask layermask;
    [SerializeField] private float gravity;
    [SerializeField] private float fallGravity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse); //AddForce kuvvet uygular
        }

        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravity;
        }

        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallGravity;
        }
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(feetPos.position, radius, layermask);
    }
}
