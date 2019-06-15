using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasControle : MonoBehaviour
{

    public Sprite[] imagens;
   public Image[] elementoPosition;
    public float intervaloMax = 5;
    public float intervaloMin = 2f;
    float timeSorteio;

    // Start is called before the first frame update
    void Start()
    {
        timeSorteio = Random.RandomRange(intervaloMax, intervaloMin);
    }

    // Update is called once per frame
    void Update()
    {
        
        timeSorteio -= Time.deltaTime;
        if (timeSorteio < 0) {
        for (int i =0; i<4;i++)
        {
            elementoPosition[i].GetComponent<Image>().sprite = imagens[Random.RandomRange(0, 9)];
        }
           timeSorteio = Random.RandomRange(intervaloMax, intervaloMin);

      }
   }
}
