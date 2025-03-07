using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    [SerializeField] private Transform enemyPrefab;
    [SerializeField] private Transform enemySpawnPos;
    
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
            for (int i=0; i<1; i++)
            {
                SpawnEnemy();
                moveEnemy = false;
            }
            
        }

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, enemySpawnPos.position, enemyPrefab.transform.rotation);
    }

}
