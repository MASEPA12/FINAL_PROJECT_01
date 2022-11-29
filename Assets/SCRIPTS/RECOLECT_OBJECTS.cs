using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECOLECT_OBJECTS : MonoBehaviour
{
    //we asign the script to the player

    public GameObject[] prefabs; //array were we put the prefabs enemies[0] and recolectables[1]
                                 // [0]-->enemy [1]-->flower [2]-->polen

    [SerializeField] private int points;
    private int flowerPoints = 2;
    private int polenPoints = 5;

    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == prefabs[0])
        {
            
        }

        if (other.gameObject == prefabs[1])
        {
            Destroy(other.gameObject);
            points = points + flowerPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject == prefabs[2])
        {
            Destroy(other.gameObject);
            points = points + polenPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }
    }
}
