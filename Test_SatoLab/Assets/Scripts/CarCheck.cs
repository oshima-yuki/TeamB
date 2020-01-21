using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCheck : MonoBehaviour
{
    static int cCount_1;
    static int cCount_2;
    static int cCount_3;
    public bool flag1 = true;
    public bool flag2 = true;
    public bool flag3 = true;
    public Rank_Management rank_Management;

    private void Start()
    {
    }

    public static int GetPC1()
    {
        return cCount_1;
    }

    public static int GetPC2()
    {
        return cCount_2;
    }

    public static int GetPC3()
    {
        return cCount_3;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && flag1 == true)
        {
            cCount_1++;
            //Debug.Log("PL1:" + cCount_1);
            flag1 = false;
        }


        if (other.gameObject.tag == "Player2" && flag2 == true)
        {
            cCount_2++;
            //Debug.Log("PL2:" + cCount_2);
            flag2 = false;
        }

        if (other.gameObject.tag == "Player3" && flag3 == true)
        {
            cCount_3++;
            //Debug.Log("PL2:" + cCount_2);
            flag3 = false;
        }
    }

}
