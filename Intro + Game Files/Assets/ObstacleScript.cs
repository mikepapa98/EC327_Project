using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    bool Hitted = false;
    void OnTriggerEnter2D (Collider2D collider)
    {
        //Debug.Log("Collision detected");
        if ((collider.gameObject.name.Equals("Player")&&(Hitted == false)))
        {
            Hitted = true;
            HealthControl.health -= 1; 
            //Debug.Log(HealthControl.health);   
            gameObject.active = false;  
        }      
    }

}
