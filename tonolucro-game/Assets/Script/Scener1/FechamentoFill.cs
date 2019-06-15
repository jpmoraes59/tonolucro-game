using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FechamentoFill : MonoBehaviour
{

   

  
    void Start()
    {
        
    }

    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("mapatopo"))
        {
            SceneManager.LoadScene("SaindoEntrega",LoadSceneMode.Single);
        }
    }
        
}
