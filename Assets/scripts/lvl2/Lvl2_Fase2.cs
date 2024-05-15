using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2_Fase2 : MonoBehaviour
{
    public List<GameObject> pinchos;

    int i=0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
                InvokeRepeating("Mostrar", 0,0.2f);
            
        }
    }

    void Mostrar()
    {
        
        if (i < pinchos.Count)
        {
            pinchos[i].gameObject.SetActive(true);
            i++;
        }
        else
        {
            gameObject.SetActive(false);    
        }
        
    }
}
