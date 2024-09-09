using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public GameObject obj, destino;
    public float speed;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            StartCoroutine(Lerp(obj.transform.position, destino.transform.position, speed));
            
        }
    }

    IEnumerator Lerp(Vector2 startPosition, Vector2 targetPosition, float lerpDuration)
    {
        float timeElapsed = 0f;
        while (timeElapsed < lerpDuration)
        {
            obj.transform.position = Vector2.Lerp(startPosition, targetPosition, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        obj.transform.position = targetPosition;
        gameObject.SetActive(false);
    }
}
