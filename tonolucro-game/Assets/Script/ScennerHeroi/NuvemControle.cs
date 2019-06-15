using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemControle : MonoBehaviour
{
    private Sprite filho;
    public Sprite[] imagen;
    void Start()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = imagen[Random.RandomRange(0,imagen.Length)];
         
    }
}
