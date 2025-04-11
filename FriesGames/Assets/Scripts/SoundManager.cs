using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] private AudioClip attackEnemy;
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip fall;
    [SerializeField] private AudioClip winsound;
    //[SerializeField] private AudioClip land;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void AttackEnemy()
    {
        audioSource.PlayOneShot(attackEnemy);
    }

    public void Jump()
    {
        audioSource.PlayOneShot(jump);
    }

    public void Fall()
    {
        audioSource.PlayOneShot(fall);
    }

    public void WinSound()
    {
        audioSource.PlayOneShot(winsound);
    }

    /* public void Land()
    {
        audioSource.PlayOneShot(land);
    } */


}
