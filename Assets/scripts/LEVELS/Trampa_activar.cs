using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


public class Trampa_activar : MonoBehaviour
{
    public GameObject obj;
    public UnityEvent objActive;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            //obj.gameObject.SetActive(true);
            objActive?.Invoke();
        }
    }
}
