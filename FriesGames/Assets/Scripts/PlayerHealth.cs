using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    UIManager UIManagerscript;
    LevelManagerScript levelmanagerscript;
    [SerializeField] private Image[] playerLives;
    [SerializeField] private int playerlife = 3;
    
    void Start()
    {
        levelmanagerscript = GameObject.Find("Level Manager").GetComponent<LevelManagerScript>();
        UIManagerscript = GameObject.Find("UI Manager").GetComponent<UIManager>();
    }

    public void Lives()
    {
        playerlife--;
        Destroy(playerLives[playerlife]);

        if(playerlife < 1)
        {
            levelmanagerscript.isLife = false;
            UIManagerscript.GetComponent<Canvas>().enabled = true;
        }
        
    }

    
}
