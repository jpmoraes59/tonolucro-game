using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaPointControle : MonoBehaviour
{
    Touch toque;
    public GameObject lamina;
    private GameObject line;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            toque = Input.GetTouch(1);
                
            Debug.Log("Tocou");
            line = Instantiate(lamina, transform);

            if (toque.phase == TouchPhase.Moved)
            {
                transform.Translate(toque.position);
               
            } else if (toque.phase == TouchPhase.Ended)
            {
                transform.position = transform.position;
            }
          
        }
        
    }
}
