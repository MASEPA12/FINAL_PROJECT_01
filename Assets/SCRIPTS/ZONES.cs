using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZONES : MonoBehaviour
{
    public GameObject flower;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomPosition()
    {
        BoxCollider = GetComponent<BoxCollider>();

        float xlim = box.size.x / 2;
        float ylim = box.size.y / 2;
        float zlim = box.size.z / 2;

        float x = RandomPosition(xlim, ylim, zlim);
        float y = RandomPosition(xlim, ylim, zlim);
        float z = RandomPosition(xlim, ylim, zlim);

        Vector3 center = transfom.position;

        Instantiate(flower, center, Quaternion.identity);

        return new Vector3(x, y, z);
    }

     
}
