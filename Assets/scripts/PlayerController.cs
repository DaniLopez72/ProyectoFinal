using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    Rigidbody2D rb;
    public float force = 50;
    public float speed = 60;
    public bool suelo;
    public float lenght = 1;
    public LayerMask mask;

    public List<Vector3> originPoints;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(horizontal * Time.deltaTime * speed, 0);
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && suelo)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
            {
                rb.gravityScale *= -1;
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
            rb.AddForce(new Vector2(0, force));
            }

        }
          suelo = false;
        for (int i = 0; i < originPoints.Count; i++)
        {
            Debug.DrawRay(transform.position + originPoints[i], Vector3.down * lenght, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + originPoints[i], Vector3.down, lenght, mask);
            if (hit.collider != null)
            {
                Debug.DrawRay(transform.position + originPoints[i], Vector3.down * lenght, Color.green);
                suelo = true;
                if (hit.collider.tag == "Trampolin")
                {
                    rb.velocity = new Vector2(0, 0);
                    rb.AddForce(new Vector2(0, 30), ForceMode2D.Impulse);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "muerte")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.tag == "Teleport")
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
