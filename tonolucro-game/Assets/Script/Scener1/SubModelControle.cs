using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubModelControle : MonoBehaviour
{
    Rigidbody2D corpoRigido;
    public float forcaMAx = 0.5f;
    public float forcaMin = 0.2f;
 
    void Start()
    {
        corpoRigido = GetComponent<Rigidbody2D>();
        Vector3 position = transform.position;
        corpoRigido.AddForce(transform.up * Random.RandomRange(forcaMAx, forcaMin), ForceMode2D.Impulse);
        position.z = Random.RandomRange(0,max:360);
        transform.position = position;
        Destroy(gameObject, 3f);
    }

  
    void Update()
    {
        
    }
}
