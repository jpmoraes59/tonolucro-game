using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemControle : MonoBehaviour
{
    private Vector2 velocity = Vector2.zero;
    private Rigidbody2D corporigido;
    float velocidade = 5;
    private Sprite filho;
    public Sprite[] imagen;
    void Start()
    {
        corporigido = GetComponent<Rigidbody2D>();
        GetComponentInChildren<SpriteRenderer>().sprite = imagen[Random.RandomRange(0,imagen.Length)];
    

    }
    private void Update()
    {
        corporigido.velocity = new Vector2(corporigido.velocity.x, Random.RandomRange(1, velocidade) * -1);
        Destroy(gameObject, 5f);
    }
}
