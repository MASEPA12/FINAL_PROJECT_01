using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BORDERS : MonoBehaviour
{

    private float Xrange = 513f; //front-back
    private float Zrange = 231f; //left-right
   

    void Update()
    {
       inScreen();
       beforeRiver();
    }

    private void inScreen()
    {
        Vector3 position = transform.position;

        if (position.x > Xrange) //if the position of the object is greater than the right border, it's position will be the limit.
        {
            transform.position = new Vector3(Xrange, position.y, position.z);
        }
        if (position.x < -Xrange) //if the position of the GO is lesser than the left border, it's position will be the limit.
        {
            transform.position = new Vector3(-Xrange, position.y, position.z);
        }

        if (position.z > Zrange) //if the position of the object is greater than the front border, it's position will be the limit.
        {
            transform.position = new Vector3(position.x, position.y, Zrange);
        }
        if (position.z < -Zrange) //if the position of the GO is lesser than the back border, it's position will be the limit.
        {
            transform.position = new Vector3(position.x, position.y, -Zrange);
        }
    }


    private void beforeRiver()
    {
        Vector3 position = transform.position;

        float axisXpositive = 225f;
        float axisZallowed = -160f;
        float axisXnegative = -134.9f;
               

        if (position.x < axisXpositive && position.x > axisXnegative && position.z <= axisZallowed)
        {
            transform.position = new Vector3(position.x, position.y, axisZallowed);
        }

        float axisZfront = -163f;
        float axisZback = -231f;
        float axisXallowedR = -145f;
         
        //if 0 > x > -145   and                             -163 > z > -231
        if(position.x < 0f && position.x > axisXallowedR && position.z < axisZfront && position.z > axisZback)
        {
            transform.position = new Vector3(axisXallowedR, position.y, position.z);
        }
           
        float axisXallowedL = 231f;

        //if 231 > x > 0                                     -163 > z > -231
        if (position.x < axisXallowedL && position.x > 0f && position.z < axisZfront && position.z > axisZback)
        {
            transform.position = new Vector3(axisXallowedL, position.y,position.z);
        }
    }
}
