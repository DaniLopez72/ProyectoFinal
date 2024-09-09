using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa_quitar : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        obj.gameObject.SetActive(false);
    }
}
