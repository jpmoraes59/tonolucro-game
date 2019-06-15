using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralalax : MonoBehaviour
{
    waypointInferior waypointI;
    public GameObject spawMapa;
    public GameObject  mapaObjt;

    private void Start()
    {
        Instantiate(mapaObjt, spawMapa.transform.position, transform.rotation);
        mapaObjt.transform.SetParent(null);
    }
    // Update is called once per frame
    void Update()
    {
        
        waypointI = GetComponentInChildren<waypointInferior>();
        if (waypointI.waypoynt_topo_detectado)
        {
            Instantiate(mapaObjt,spawMapa.transform.position,transform.rotation);
            mapaObjt.transform.SetParent(null);
            waypointI.waypoynt_topo_detectado = false;
        }
    }
}
