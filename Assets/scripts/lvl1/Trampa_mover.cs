using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trampa_mover : MonoBehaviour
{
    public GameObject obj, destino1, destino2;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "player")
        {
            
            StartCoroutine(Lerp(obj.transform.position, destino1.transform.position,5f));
            StartCoroutine(Lerp(obj.transform.position, destino2.transform.position,5f));
            gameObject.SetActive(false);
            
        }
    }

    IEnumerator Lerp(Vector2 startPosition, Vector2 targetPosition, float lerpDuration)
    {
        float timeElapsed = 0f;
        while (timeElapsed < lerpDuration)
        {
            obj.transform.position = Vector2.Lerp(startPosition, targetPosition, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        obj.transform.position = targetPosition;
    }
}
