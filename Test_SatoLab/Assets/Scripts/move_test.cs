using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_test : MonoBehaviour
{
    Rigidbody rd;
    Transform myT;
    int y1 = -1;
    int y2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Rigidbody>();
        myT = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(0.0f, 0.0f, 13.0f);
        if (force.z < 15.0f)
        {
            rd.AddForce(force);
        }
    }
}
