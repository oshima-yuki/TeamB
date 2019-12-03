using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_1 : MonoBehaviour
{
    public static int cCount_1 = 0;
    public int cCount_2;
  
    //private void Update()
    //{
    //    cCount_2 = checkpoint_2.cCount_2;
    //    if (cCount_1 > cCount_2)
    //    {
    //        Debug.Log("PL1:1位");
    //    }
    //    if (cCount_1 < cCount_2)
    //    {
    //        Debug.Log("PL1:2位");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPoint1")
        {
            Debug.Log("PL1:"+cCount_1);
            cCount_1++;
        }
        /*if (other.gameObject.tag == "CheckPoint1")
        {
            if (cCount_1 == 0)
            {
                cCount_1 = 1;
                Debug.Log("通過");
            }
            else
            {
                Debug.Log("逆走");
            }
        }
        if (other.gameObject.tag == "CheckPoint2")
        {
            if (cCount_1 == 1)
            {
                cCount_1 = 2;
                Debug.Log("2通過");
            }
            else
            {
                Debug.Log("逆走");
            }
        }*/
    }

}
