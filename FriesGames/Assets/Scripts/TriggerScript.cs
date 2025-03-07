using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    [SerializeField] private Transform enemy;
    [SerializeField] private float enemeySpeed;
    private bool moveEnemy = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moveEnemy = true;
        }
    }
    private void FixedUpdate()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        if (moveEnemy)
        {
            moveEnemy = true;
            enemy.GetComponent<Rigidbody2D>().velocity=new Vector2(-1 * enemeySpeed,0);
            
        }

    }

}
