using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject nextLevel, nextLevelCamera, player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position=nextLevel.transform.position;
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        Camera.main.transform.position = nextLevelCamera.transform.position;

    }


}
