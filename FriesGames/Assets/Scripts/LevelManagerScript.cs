using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform playerSpawnPos;
    
    void Awake()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        Instantiate(playerPrefab, playerSpawnPos.position, Quaternion.identity); //Quaternion.identity X,Y,Z kordinatlarýný sýfýrlar.
    }

    public void RespawnPlayer()
    {

        Invoke("SpawnPlayer", 1f);
    }
}

    
    

