using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCompnentItem : MonoBehaviour
{

    public Sprite[] imagens;
    public Sprite[] subImagem;
    public GameObject subModel;
    private Sprite imagemL;
    private Sprite imaagemR;
    private Sprite spriteAtual;
   
    Rigidbody2D corpoRigido;
    public float forcaMAx = 10f;
    public float forcaMin = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        corpoRigido = GetComponent<Rigidbody2D>();
        corpoRigido.AddForce(transform.up * Random.RandomRange(forcaMAx, forcaMin), ForceMode2D.Impulse);
        GetComponent<SpriteRenderer>().sprite = imagens[Random.RandomRange(0, 9)];
        spriteAtual = GetComponent<SpriteRenderer>().sprite;
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("laminaPlayer"))
        {
            Debug.Log("Colider Alimentacao enter");
            for (int i =0; i< subImagem.Length;i++)
            {
                if (subImagem[i].name.Equals(spriteAtual.name+"L")|| subImagem[i].name.Equals(spriteAtual.name + "R"))
                {
                    subModel.GetComponent<SpriteRenderer>().sprite = subImagem[i];
                    GameObject obj = subModel;
                    float contTemp = Random.RandomRange(0,3);
                    if (contTemp == 0|| contTemp == 2) { 
                    Instantiate(obj, transform);
                    }
                    else{
                        Instantiate(obj, transform.position, transform.rotation);
                    }
                    obj.transform.SetParent(null);
                    Destroy(gameObject);
                   
                }
            }

        }
    }
}