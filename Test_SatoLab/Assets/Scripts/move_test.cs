
﻿using System.Collections;
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, 10.0f);
            rd.AddForce(force);
        }
        else
        {
            Vector3 force = new Vector3(0.0f, 0.0f, -1.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myT.Rotate(0, y1, 0);
            if (y1>30)
            {
                y1 = 30;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myT.Rotate(0, y2, 0);
            if (y2>30)
            {
                y2 = 30;
            }
        }

    }
}

