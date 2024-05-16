using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lvl2Fase5 : MonoBehaviour
{
    public GameObject obj, destino;
    public float speed=2.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "player")
        {
            
            StartCoroutine(Lerp(obj.transform.position, destino.transform.position,speed));

            //obj.transform.position = Vector3.MoveTowards(obj.transform.position, destino.transform.position, 5f);
            
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
    }
}
