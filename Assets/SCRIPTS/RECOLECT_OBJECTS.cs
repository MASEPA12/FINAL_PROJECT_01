using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECOLECT_OBJECTS : MonoBehaviour
{
    //we asign the script to the player in order to detect collisions
    
    [SerializeField] private int points;
    private int flowerPoints = 2;
    private int polenPoints = 5;
    private float flowerRANGE;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name.Contains("enemy")) //if the player collide with the ENEMY;
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
            Destroy(gameObject); //destroy player
        }

        if (other.gameObject.name.Contains("flower")) //if the player collide with the FLOWER;
        {
            Destroy(other.gameObject);
            points = points + flowerPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject.name.Contains("polen")) //if the player collide with the POLEN;
        {
            Destroy(other.gameObject);
            points = points + polenPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }
    }
}
