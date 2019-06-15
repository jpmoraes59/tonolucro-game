using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GararBola : MonoBehaviour
{
    public GameObject bolas;
    public float timeMax = 2f;
    public float timeMin = 0.5f;

    public Transform[] spawPoints;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            float time = Random.Range(timeMax,timeMin);
            yield return new WaitForSeconds(1f);

            int indice = Random.Range(0,spawPoints.Length);
            Transform spawpoint = spawPoints[indice];
            GameObject spawpointTemp = Instantiate(bolas, spawpoint.position, spawpoint.rotation);
            Destroy(spawpointTemp, 5f);


        }
    }
}
