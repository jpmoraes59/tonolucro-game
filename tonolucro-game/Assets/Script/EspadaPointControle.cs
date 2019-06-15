using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaPointControle : MonoBehaviour
{

    Rigidbody2D corpoRigido;
    CircleCollider2D colider;
    Camera cam;

    Touch toque;
    public GameObject lamina;
    private GameObject line;
    public bool isCorte;
    public Vector2 ultimaPosicao;
    public float velocidadeMinimaCorte = 0.001f;

 

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        corpoRigido = GetComponent<Rigidbody2D>();
        colider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            inciarCorte();
        } else if (Input.GetMouseButtonUp(0))
        {
            pararCorte();
        }

        if (isCorte)
        {
            UptadeCorte();
        }
        
    }
    void UptadeCorte()
    {
        Vector2 novaPosicao = cam.ScreenToWorldPoint(Input.mousePosition);
        corpoRigido.position = novaPosicao;
        float velocidade = (novaPosicao - ultimaPosicao).magnitude * Time.deltaTime;

        if (velocidade > velocidadeMinimaCorte)
        {
            colider.enabled = true;
        }
        else
        {
            colider.enabled = false;
        }

        ultimaPosicao = novaPosicao;
    }

    void inciarCorte()
    {
        isCorte = true;
        colider.enabled = true;
        ultimaPosicao = cam.ScreenToViewportPoint(Input.mousePosition);
    }

    void pararCorte()
    {
        isCorte = false;
        colider.enabled = false;

    }
}
