using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trampa_activar : MonoBehaviour
{
    public GameObject obj;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            obj.gameObject.SetActive(true);
            
        }
    }
}
