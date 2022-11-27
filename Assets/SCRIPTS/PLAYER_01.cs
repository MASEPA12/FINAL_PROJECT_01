using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_01 : MonoBehaviour
{

    private float speed = 2f;
    private float turnSpeed = 10f;
    private float horitzontalInput;
    private float verticalInput;
    private float jumpInput;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); 

        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * horitzontalInput); //rotation

        horitzontalInput = Input.GetAxis("Horizontal"); //movement left/right
        transform.Translate(Vector3.right * speed * Time.deltaTime * horitzontalInput);
        
        jumpInput = Input.GetAxis("Jump"); //movement for jump
        transform.Translate(Vector3.up * speed * Time.deltaTime * jumpInput);
    }
}
