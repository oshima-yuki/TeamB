using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Distance : MonoBehaviour
{

    public GameObject[] Player;
    public GameObject[] PL1ch;
    public GameObject[] PL2ch;
    float PL1D;
    public float timeCount = 1.5f;
    static int p1;
    static int p2;
    public int Array_Count;
    static int AC;

    public static int P1AC()
    {
        return AC;
    }

    // Start is called before the first frame update
    void Start()
    {
        AC = Array_Count - 1;
    }

    // Update is called once per frame
    void Update()
    {
        p1 = hit_Check.GetPL1();
        p2 = hit_Check.GetPL2();
        //Debug.Log("p1:"+p1);
        float PL1D = Vector3.Distance(Player[0].transform.position, PL1ch[p1].transform.position);
        //Debug.Log("PL1:" + PL1D);

        Debug.Log("p2:" + p2);
        p2 = hit_Check.GetPL2();
        float PL2D = Vector3.Distance(Player[1].transform.position, PL2ch[p2].transform.position);
        //Debug.Log("PL2:" + PL2D);
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (hit == true)
        {
            PL1chp++;
            hit = false;
        }

        if (timeCount <= 0)
        {
            hit = true;
            timeCount = 1.5f;
        }
    }*/
}
