using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteTouch : MonoBehaviour
{

    Camera cam;
    public Text textCOmponente;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        textCOmponente.GetComponent<Text>().text = " "+ cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
