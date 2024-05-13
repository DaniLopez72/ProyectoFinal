using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject nextLevel, nextLevelCamera, player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position=nextLevel.transform.position;
        Camera.main.transform.position = nextLevelCamera.transform.position;

    }


}
