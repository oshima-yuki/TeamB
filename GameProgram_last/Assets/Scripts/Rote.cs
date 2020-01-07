using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rote : MonoBehaviour
{
    public int count;
    public GameObject[] target;
    Quaternion rote;
    int i;
    public int x;
    public int y;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rote = this.transform.localRotation;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            for (i = 0; i < count; i++)
            {
                rote.x = x;
                rote.y = y;
                target[i].transform.rotation = Quaternion.Euler(rote.x, rote.y, 0);
            }
            Destroy(this.gameObject);
        }
    }
}
