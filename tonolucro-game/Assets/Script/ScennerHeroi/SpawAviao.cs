using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawAviao : MonoBehaviour
{
    public GameObject[] spawPoints;
    private GameObject spawponit;
    public float timeMax;
    public float timeMin;
    public GameObject obstaculos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float time = Random.Range(timeMax, timeMin);
            yield return new WaitForSeconds(1f);

            int indice = Random.Range(0, spawPoints.Length);
            Transform spawponit = spawPoints[indice].transform;
            GameObject spawpointTemp = Instantiate(obstaculos, spawponit.position, spawponit.rotation);
            Destroy(spawpointTemp, 5f);


        }
    }
}
