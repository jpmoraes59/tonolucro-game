using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaCorrer : MonoBehaviour
{

  
    private Rigidbody2D corporigido;
    float velocidade = 4;
 
    void Start()
    {
        corporigido = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        corporigido.velocity = new Vector2(corporigido.velocity.x,velocidade*-1);

        Destroy(gameObject,5f);
    }
}