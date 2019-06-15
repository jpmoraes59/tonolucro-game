using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCompnentItem : MonoBehaviour
{

    Rigidbody2D corpoRigido;
    public float forcaMAx = 1.4f;
    public float forcaMin = 0.8f;
    
    // Start is called before the first frame update
    void Start()
    {
        corpoRigido = GetComponent<Rigidbody2D>();
        corpoRigido.AddForce(transform.up*Random.RandomRange(forcaMAx,forcaMin),ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
