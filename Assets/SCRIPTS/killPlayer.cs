using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{
    public GameObject player; //array were we put the player[0] 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player) //if the collision is between the enemy and the game object, the player will be destroyed and it's game over
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
            Destroy(other.gameObject); //destroy player
        }
    }
}
