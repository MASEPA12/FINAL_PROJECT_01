using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    [SerializeField] private int points;
    //private int flowerPoinits = 2;
    //private int polenPoints = 5;
    public float startDelay = 2f;

void Start() //it is suposed control the times between the text
    {
        //InvokeRepeating("context", startDelay);
    }

//Here there are all the functions separated by the type; context (first text), howToPlay (second text, 10second after the first) and readyGo (final text)
    void context()
    {
        Debug.Log("Hello! We don't have a lot of time; the bee queen is staarving and we got to seach food as much as we can in order to complain her.");
        Debug.Log("If we get the queen happy, there won't be any problem, but if we don't... I don't want to imagin how mad shi will be! ");
    }
}
