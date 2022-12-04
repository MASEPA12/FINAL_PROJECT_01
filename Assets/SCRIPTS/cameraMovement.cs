using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    private float speed = 15f;
    private float turnSpeed = 100f;
    private float rotationInput;
    private float verticalInput;
    //private float jumpInput;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.up * speed * Time.deltaTime * verticalInput);

        rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * rotationInput); //rotation
    }
}
