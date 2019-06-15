using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EspadaPointControle : MonoBehaviour
{

    Rigidbody2D corpoRigido;
    CircleCollider2D colider;
    Camera cam;
    public GameObject canvasListaSlot;

    public Text placar;
    private int cont;
    public bool alimentacaoCerta;
  

    public GameObject lamina;
    private GameObject line;

    public bool isCorte;
    public Vector2 ultimaPosicao;
    public float velocidadeMinimaCorte = 0.001f;

 

    // Start is called before the first frame update
    void Start()
    {
        alimentacaoCerta = false;
        cam = Camera.main;
        corpoRigido = GetComponent<Rigidbody2D>();
        colider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       alimentacaoCerta = false;
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
        line = Instantiate(lamina,transform);
        colider.enabled = true;
        ultimaPosicao = cam.ScreenToViewportPoint(Input.mousePosition);
    }

    void pararCorte()
    {
        line.transform.SetParent(null);
        Destroy(line, 2f);
        isCorte = false;
        colider.enabled = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag.Equals("alimentos")){
          Image[] lista = canvasListaSlot.GetComponent<CanvasControle>().elementoPosition;
            Debug.Log(collision.GetComponent<SpriteRenderer>().sprite.name);
            for (int i=0;i < 4;i++)
            {
                if (lista[i].GetComponent<Image>().sprite.name.Equals(collision.GetComponent<SpriteRenderer>().sprite.name))
                    alimentacaoCerta = true;
                    placar.GetComponent<Text>().text =(cont += 1)+"";
                    Debug.Log("ISSSOOO AIIII MALLUCCOOOOOO");
                    return;
                }
            }
        }
    }

