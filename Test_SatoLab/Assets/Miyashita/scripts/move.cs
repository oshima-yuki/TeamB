using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
 

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rd = this.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f,0.0f,1.0f);
        rd.AddForce(force);
    }
}
