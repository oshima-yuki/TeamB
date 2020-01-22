using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_2 : MonoBehaviour
{
     public static int cCount_2 = 0;

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPoint1")
        {
            cCount_2++;
            Debug.Log("PL2:" + cCount_2);
        }
        /*if (other.gameObject.tag == "CheckPoint1")
        {
            if (cCount_2 == 0)
            {
                cCount_2 = 1;
                Debug.Log("通過");
            }
            else
            {
                Debug.Log("逆走");
            }
        }
        if (other.gameObject.tag == "CheckPoint2")
        {
            if (cCount_2 == 1)
            {
                cCount_2 = 2;
                Debug.Log("2通過");
            }
            else
            {
                Debug.Log("逆走");
            }
        }*/

    }
    }
