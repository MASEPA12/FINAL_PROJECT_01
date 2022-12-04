using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RECOLECT_OBJECTS : MonoBehaviour
{
    //we asign the script to the player

    public GameObject[] prefabs; //array were we put the prefabs enemies[0] and recolectables[1]
                                 // [0]-->enemy [1]-->flower [2]-->polen
                                 // 1,2,3 = FLOWER,FLOWER(1),FLOWER(2)
                                 // 4,5,6 = POLEN, POLEN (1), POLEN(2)

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

        if (other.gameObject == prefabs[1] || other.gameObject == prefabs[2] || other.gameObject == prefabs[3])
        {
            Destroy(other.gameObject);
            points = points + flowerPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }

        if (other.gameObject == prefabs[4] || other.gameObject == prefabs[5] || other.gameObject == prefabs[6])
        {
            Destroy(other.gameObject);
            points = points + polenPoints;
            Debug.Log($"TOTAL SCORE: {points}");
        }
    }
}
