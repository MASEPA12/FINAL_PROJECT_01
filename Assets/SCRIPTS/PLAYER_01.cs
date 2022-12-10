using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_01 : MonoBehaviour
{ 
    //Setting the variables for the speed and the inputs;
    private float speed = 50f;
    private float turnSpeed = 100f;
    private float rotationInput;
    private float verticalInput;

    void Update()
    {   
        /*This is the variable that gets to the vertical input, so when the vertical input is touched
        we multiply it with the speed, avance (0,0,1) and correction of time. Same with rotation*/

        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * rotationInput); //rotation
    }
}
