using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trampa_timer : MonoBehaviour
{
    
    public UnityEvent objActive;
    public UnityEvent objInactive;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        objActive?.Invoke();
        Invoke("Clear", 2);
    }

    void Clear()
    {
        objInactive?.Invoke();
    }
}
