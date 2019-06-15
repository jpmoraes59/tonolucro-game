using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroiControll : MonoBehaviour
{

    Rigidbody2D corpoRigido;
    float velocidade = 1f;
    public Text textPlacar;
    int temp;
   public GameObject menuINGame;

   
   
    void Start()
    {
        corpoRigido = GetComponent<Rigidbody2D>();
    }

    public void Direita() {
        corpoRigido.velocity = new Vector2(velocidade*2, corpoRigido.velocity.y);
    }
    public void Esquerda()
    {
        corpoRigido.velocity = new Vector2((velocidade * 2)*-1, corpoRigido.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.tag.Equals("Obstaculo"))
        {
            menuINGame.active = true;
           Time.timeScale = 0;
       }
   }

 
    }
