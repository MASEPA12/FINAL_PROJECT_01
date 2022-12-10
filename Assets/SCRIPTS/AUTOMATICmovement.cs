using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUTOMATICmovement : MonoBehaviour
{
    public float A;
    public float B;
    public float speed;

    void Update()
    {
        BearMovement(A, B);
    }

    private void BearMovement(float a, float b)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //automatic front movement
        //Debug.Log($"transform.position.z = {transform.position.z}");

        if (transform.position.z >= b || transform.position.z <= a)
        {
            transform.Rotate(Vector3.up, 180f); //rotate in axis y (Vector3.up {0,1,0}) 180 degrees 
        }
    }

}
