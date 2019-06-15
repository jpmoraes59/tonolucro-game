using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointInferior : MonoBehaviour
{
   public bool waypoynt_topo_detectado = false;
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("mapatopo"))
        {
            waypoynt_topo_detectado = true;
        }
    }
}
