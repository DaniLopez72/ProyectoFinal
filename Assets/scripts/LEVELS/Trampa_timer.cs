using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa_timer : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        obj.SetActive(true);
        Invoke("Clear", 2);
    }

    void Clear()
    {
        gameObject.SetActive(false);
        obj.SetActive(false);
    }
}
