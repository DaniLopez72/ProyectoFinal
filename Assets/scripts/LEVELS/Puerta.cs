using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject nextLevel, player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position=nextLevel.transform.position;
    }
}
