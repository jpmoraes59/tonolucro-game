using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContBarreira : MonoBehaviour
{
    public Text contPuntucaçao;
    private int cont;
    public Image barraProgresso;
    public Image finalGame;
    float taime = 0.2f;
    float temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = taime;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (barraProgresso.fillAmount ==1)
        {
            temp = Time.deltaTime;
            if (temp < 0) {
                barraProgresso.fillAmount = (2 / 100);
                temp = taime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Obstaculo"))
        {
            contPuntucaçao.GetComponent<Text>().text = (cont++)+""; 
        }
    }
}
