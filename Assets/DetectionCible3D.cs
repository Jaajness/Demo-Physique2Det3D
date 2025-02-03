using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCible3D : MonoBehaviour

{

    void OnTriggerEnter(Collider collision)
    {
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
     
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Cible"))
        {
            print(collision.gameObject.name + " : " + collision.gameObject.tag);
            Destroy(collision.gameObject);
        }

    }
}
