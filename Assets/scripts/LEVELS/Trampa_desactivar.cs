using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trampa_desactivar : MonoBehaviour
{
    public GameObject obj, destino;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            obj.transform.position = destino.transform.position;
            transform.parent.gameObject.SetActive(false);
            
        }
    }
}
