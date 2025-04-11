using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    WinScreenText winScreenTextScript;
    SoundManager soundManager;

    private void Start()
    {
        winScreenTextScript = GameObject.Find("Win Screen").GetComponent<WinScreenText>();
        soundManager = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            winScreenTextScript.GetComponent<Canvas>().enabled = true;
            soundManager.WinSound();
            Destroy(collision.gameObject);
            
        }
    }

    
}
