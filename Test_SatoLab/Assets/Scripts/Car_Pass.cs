using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Pass : MonoBehaviour
{
    static int PL1_hit;
    bool P1ch = true;
    GameObject[] chpoint;
    int count = 0;
    int ch = 0;
    int[] Check;

    public static int GetPL1()
    {
        return PL1_hit;
    }

    // Start is called before the first frame update
    void Start()
    {
        chpoint = GameObject.FindGameObjectsWithTag("CheckPoint");
        foreach (GameObject ob in chpoint)
        {
            count++;
            //Debug.Log(chpoint);
        }
        Debug.Log("カウント" + count);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PL1_hit);
        //Debug.Log("ch:" + ch);
        //Debug.Log("カウント" + count);
        Debug.Log("a"+chpoint[count]);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (chpoint[count])
        {
            if (other.gameObject.tag == "CheckPoint")
            {
                PL1_hit++;
                count++;
            }
        }
    }
}
