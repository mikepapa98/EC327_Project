using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthControl : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int health;
    void Start()
    {
        health = 3;
        heart1.gameObject.GetComponent<Renderer>().enabled = true;
        heart2.gameObject.GetComponent<Renderer>().enabled = true;
        heart3.gameObject.GetComponent<Renderer>().enabled = true;
    }
    void Update()
    {
        
        switch (health)
        {
            case 3:
                heart1.gameObject.GetComponent<Renderer>().enabled = true;
                heart2.gameObject.GetComponent<Renderer>().enabled = true;
                heart3.gameObject.GetComponent<Renderer>().enabled = true;
                break;
            case 2:
                heart1.gameObject.GetComponent<Renderer>().enabled = true;
                heart2.gameObject.GetComponent<Renderer>().enabled = true;
                heart3.gameObject.GetComponent<Renderer>().enabled = false;
                break;
            case 1:
                heart1.gameObject.GetComponent<Renderer>().enabled = true;
                heart2.gameObject.GetComponent<Renderer>().enabled = false;
                heart3.gameObject.GetComponent<Renderer>().enabled = false;
                break;
            case 0:
                heart1.gameObject.GetComponent<Renderer>().enabled = false;
                heart2.gameObject.GetComponent<Renderer>().enabled = false;
                heart3.gameObject.GetComponent<Renderer>().enabled = false;
                Time.timeScale = 0;
                SceneManager.LoadScene (sceneName:"GameOver");
                break;
        }
    }
}
