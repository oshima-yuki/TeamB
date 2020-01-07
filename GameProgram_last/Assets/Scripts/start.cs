using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
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
        Debug.Log("c");
        if (other.gameObject.tag == "Player")
        {
            Time_manager.start = true;
            Destroy(this.gameObject);
        }
    }
}
