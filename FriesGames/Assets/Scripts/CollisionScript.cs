using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    [SerializeField] private float enemyAttackSpeed;
    float leftScreenBounds = -10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void FixedUpdate()
    {
        AttackEnemy();
        DestroyEnemy();
    }

    void AttackEnemy()
    {
        transform.Translate(-1 * enemyAttackSpeed * Time.deltaTime, 0, 0);
    }

    void DestroyEnemy()
    {
        if (transform.position.x < -leftScreenBounds)
        {
            Destroy(gameObject);
        }
    }
}
