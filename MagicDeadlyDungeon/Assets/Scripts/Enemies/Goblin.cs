using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour {

    Vector3 direction = new Vector3(0, 0, 1);
    public float speed =1;


    // Move it along its direction.
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
       
    }


    // If we hit a left or right wall, invert x direction.
    void OnCollisionEnter(Collision col)
    {
        //var tag = hit.gameObject.tag;
        if (col.gameObject.tag == "rightwall" || col.gameObject.tag == "leftwall")
            direction.z *= -1;
        
    }
}
