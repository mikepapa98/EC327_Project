using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{

    public GameObject heart1, heart2, heart3;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        heart1.gameObject.GetComponent<Renderer>().enabled = true;
        heart2.gameObject.GetComponent<Renderer>().enabled = true;
        heart3.gameObject.GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (health)
        {
            case 3:
                /*heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true); */
                heart1.gameObject.GetComponent<Renderer>().enabled = true;
                heart2.gameObject.GetComponent<Renderer>().enabled = true;
                heart3.gameObject.GetComponent<Renderer>().enabled = true;
                break;
            case 2:
                /*heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false); */
                heart1.gameObject.GetComponent<Renderer>().enabled = true;
                heart2.gameObject.GetComponent<Renderer>().enabled = true;
                heart3.gameObject.GetComponent<Renderer>().enabled = false;
                break;
            case 1:
                /*heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);*/
                heart1.gameObject.GetComponent<Renderer>().enabled = true;
                heart2.gameObject.GetComponent<Renderer>().enabled = false;
                heart3.gameObject.GetComponent<Renderer>().enabled = false;
                break;
            case 0:
                /*heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);*/
                heart1.gameObject.GetComponent<Renderer>().enabled = false;
                heart2.gameObject.GetComponent<Renderer>().enabled = false;
                heart3.gameObject.GetComponent<Renderer>().enabled = false;
                Time.timeScale = 0;
                SceneManager.LoadScene (sceneName:"GameOver");
                break;
        }
    }
}
