using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FackingWall : MonoBehaviour
{
    [SerializeField]
    public GameObject DestroyWall;
    public GameObject DestroyWall01;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DestroyWall")
        {
            Destroy(DestroyWall);

        }
        if (other.gameObject.tag == "DestroyWall01")
        {
            Destroy(DestroyWall01);

        }
    }
}
