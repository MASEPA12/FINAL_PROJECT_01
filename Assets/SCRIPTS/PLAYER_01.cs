using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_01 : MonoBehaviour
{
    /*coses que he de posar
     * 1- moviment en vertical (fletxa adalt i fletxa abaix)
     * 2- rotació en horitzontal (fletxa dreta i esquerra)
     */

    private float speed = 15f;
    private float turnSpeed = 100f;
    private float rotationInput;
    private float verticalInput;
    //private float jumpInput;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //movement front/back
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * rotationInput); //rotation
    }
}
