using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSTRUCTIONS : MonoBehaviour
{
    void Start()
    {
        //we set that the time scale of the game is 0 because fist we want to explain the game
        Time.timeScale = 0;
        Debug.Log("Hello! Are you ready to play? -press A to continue-");
    }

    void Update()
    {
        //if the player presses the key A (on the controller or on the keyboard) the instructions will be shown
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Joystick1Button0))
        {
            introduction();
        }
        //if the player presses the key Y (on controller) or W on the keyboard, the game will start
        if (Input.GetKey(KeyCode.Y) || Input.GetKey(KeyCode.W))
        {
            Time.timeScale = 1;
        }
    }

    void introduction()
    {
        Debug.Log("The objective of the game is get 300 points before the time is over");
        Debug.Log("Every mashroom counts diferent; the red ones 5 points, the orange ones, 2 points");
        Debug.Log("the blue ones 3 points and the purplue ones 7 points.");
        Debug.Log("all the flower count 10 points, but CAREFUL! the bears kill you");
        Debug.Log("GOOD LUCK");
        Debug.Log("press Y (on controller) or W to continue.");
    }
}
