using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    SoundManager soundManagerScript;
    LevelManagerScript levelManagerScript;
    PlayerHealth PlayerHealthscript;
    [SerializeField] private float enemyAttackSpeed;
    UIManager UIManagerScript;
    float leftScreenBounds = -10f;

    private void Awake()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        levelManagerScript = GameObject.Find("Level Manager").GetComponent<LevelManagerScript>();
        UIManagerScript = GameObject.Find("UI Manager").GetComponent<UIManager>();
        PlayerHealthscript = GameObject.Find("Level Manager").GetComponent<PlayerHealth>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            soundManagerScript.AttackEnemy();
            Destroy(collision.gameObject);
            PlayerHealthscript.Lives();
            if (levelManagerScript.isLife==true)
            {
                levelManagerScript.RespawnPlayer();
            }            
            
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
        if (transform.position.x < leftScreenBounds)
        {
            Destroy(gameObject);
        }
    }
}
