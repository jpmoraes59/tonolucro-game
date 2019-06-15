using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeCorrer : MonoBehaviour
{
    public Image barraProgresso;
    private float prograsso;
    Rigidbody2D rigidbody2D;
    public float velocidade = 3;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        prograsso = barraProgresso.GetComponent<Image>().fillAmount;
        Debug.Log(prograsso);
        if (prograsso >= 0.90)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, velocidade * 1);
        }
      
    }
}
