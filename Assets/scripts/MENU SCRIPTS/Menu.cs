using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public List<GameObject> points;
    public GameObject menu;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("mover", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void mover() {
        int num = Random.Range(0, points.Count);

        menu.transform.position = points[num].transform.position;
    }

    public void Juego()
    {
        SceneManager.LoadScene(1);
    }
    public void Niveles()
    {
        panel.SetActive(true);
    }

    public void SetNivel(int nivel)
    {
        SceneManager.LoadScene(nivel);
    }
}
