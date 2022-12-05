using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECOLECT_OBJECTS : MonoBehaviour
{
    //we asign the script to the player

   
    [SerializeField] private int points;
    private int flowerPoints = 2;
    private int polenPoints = 5;

    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("enemy"))
        {
            
        }

        if (other.gameObject.name.Contains("flower"))
        {
            Destroy(other.gameObject);
            points = points + flowerPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject.name.Contains("polen"))
        {
            Destroy(other.gameObject);
            points = points + polenPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }
    }
}
