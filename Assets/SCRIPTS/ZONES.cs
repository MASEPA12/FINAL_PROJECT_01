using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZONES : MonoBehaviour
{
    public GameObject[] objectsToRecolect;
    private int recollectableIndex;
    private BoxCollider zone1;
    [SerializeField] private float y;

    private void Update()
    {
        //CANVIAR AIXÒ PER: SI ES PLAYER TE 10 PUNTS...
        if (Time.time == 45f)
        {
            RandomPosition();
        }
    }

    Vector3 RandomPosition()
    {
                //here we asign the components of the box collider to zone1
        zone1 = GetComponent<BoxCollider>();  

                //asign each axis size of the box collider to a float variable exept y, because we need an especific high.
        float xlim = zone1.size.x / 2;  
        float zlim = zone1.size.z / 2;

                //then, we create a random number between the limit of each axis and asign it to a variable (x,y,z)
        float x = Random.Range(-xlim/2,xlim/2); 
        float z = Random.Range(-zlim/2, zlim/2);

        //SI NECESSIT SABER SA POSICIÓ DE LO QUE APAREIX PER FER PROVES: Debug.Log($"MIDES BOX: POSITIVE:{xlim/2},{zlim/2} NEGATIVE: {-xlim/2},{-zlim/2} // COOREDENADES NEWobject---> {x},{z}");    
                
        //recollectableIndex will be a random number of the array in order to instantiate a random component of the array
        recollectableIndex = Random.Range(0, objectsToRecolect.Length);

        Vector3 GameObjectCentre = transform.position; //centre is the  zone1 position

                //we instantiate a random recollectable in "new Vector3(x, y, z)".
        Instantiate(objectsToRecolect[recollectableIndex], GameObjectCentre + new Vector3(x, y, z), Quaternion.identity);

        return new Vector3(x, y, z);
    }
     
}
