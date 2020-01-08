using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_Check : MonoBehaviour
{
    static int PL1_hit;
    static int PL2_hit;
    bool P1ch = true;
    bool P2ch = true;
    int Array_Count;


    public static int GetPL1()
    {
        return PL1_hit;
    }

    public static int GetPL2()
    {
        return PL2_hit;
    }


    // Start is called before the first frame update
    void Start()
    {
        Array_Count = Car_Distance.P1AC();
        Debug.Log(Array_Count);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Array_Count1);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("PL1:" + PL1_hit);
        //Debug.Log("AC1:" + Array_Count1);
        if (other.gameObject.tag == "Player" && P1ch == true && PL1_hit <= Array_Count)
        {
            Debug.Log("通過");
            P1ch = false;
            PL1_hit++;
        }

        if (other.gameObject.tag == "Player2" && P2ch == true && PL2_hit <= Array_Count)
        {
            Debug.Log("通過");
            P2ch = false;
            PL2_hit++;
        }
    }
}