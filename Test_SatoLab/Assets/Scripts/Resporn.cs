using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resporn : MonoBehaviour
{
    public Vector3 rePos;

    // Start is called before the first frame update
    void Start()
    {
        rePos = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "check")
        {
            rePos = coll.transform.position;
        }


    }

}
