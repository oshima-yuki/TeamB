using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Pass : MonoBehaviour
{
    static int PL1_hit;
    bool P1ch = true;
    GameObject[] chpoint;
    int count;
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
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PL1_hit);
        Debug.Log("ch:" + ch);

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
