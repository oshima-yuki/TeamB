using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Stage")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Ene")
        {
            Score_Manager.score += 100;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
