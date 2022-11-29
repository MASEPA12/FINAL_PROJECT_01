using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BORDERS : MonoBehaviour
{
    //no és necessàri perquè es mapa no és quadrat

    private float Xrange = 2.9f; //front-back
    private float Zrange = 2.4f; //left-right

    void Update()
    {
        inScreen();
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
}
