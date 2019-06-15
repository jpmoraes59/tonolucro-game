using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject menuINGame;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    public void startGame()
    {

        Time.timeScale = 1;
        menuINGame.active = false;
    }
}
