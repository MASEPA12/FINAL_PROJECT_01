using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECOLECT_OBJECTS : MonoBehaviour
{
    //we asign the script to the player in order to detect collisions
    
    [SerializeField] private int points;
    private int B_points = 3;
    private int R_points = 5;
    private int O_points = 2;
    private int P_points = 7;
    private int FlowerPoints = 10;

    private float flowerRANGE;

    private void Start()
    {
        if(points >= 300)
        {
            Time.timeScale = 0;
            Debug.Log($"YOU HAVE WON 300 POINTS, CONGRATULATIONS YOU WON!!! gg");
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name.Contains("BEAR")) //if the player collide with the ENEMY;
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
            Destroy(gameObject); //destroy player
        }

        if (other.gameObject.name.Contains("Mushroom_B")) //if the player collide with the brown mushroom;
        {
            Destroy(other.gameObject);
            points = points + B_points;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject.name.Contains("Mushroom_R")) //if the player collide with the red mushroom;
        {
            Destroy(other.gameObject);
            points = points + R_points;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject.name.Contains("Mushroom_O")) //if the player collide with the orange mushroom;
        {
            Destroy(other.gameObject);
            points = points + O_points;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject.name.Contains("Mushroom_P")) //if the player collide with the purple mushroom;
        {
            Destroy(other.gameObject);
            points = points + P_points;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject.name.Contains("Flower")) //if the player collide with some flower;
        {
            Destroy(other.gameObject);
            points = points + FlowerPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }
    }
}
