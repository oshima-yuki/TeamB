using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Pass : MonoBehaviour
{
    static int PL1_hit;
    bool P1ch = true;
    GameObject[] chpoint;
    GameObject[] chpoint2;
    int count = 0;
    int count2 = 0;
    int ch = 0;
    int max = 0;
    int max2 = 0;
    int[] Check;
    public int checkpoint_count;
    public static int score1;
    public static int score2;
    public static float PL1Distance;
    public static float PL2Distance;
    //public GameObject[] chp;


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
            max++;
            //Debug.Log(chpoint);
        }
        chpoint2 = GameObject.FindGameObjectsWithTag("CheckPoint");
        foreach (GameObject ob in chpoint2)
        {
            count2++;
            max2++;
            //Debug.Log(chpoint);
        }

        Debug.Log("カウント" + count);
        count = 0;
        count2 = 0;

        score1 = checkpoint_count * 1000;
        score2 = checkpoint_count * 1000;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PL1Distance);
        //Debug.Log(PL1_hit);
        //Debug.Log("ch:" + ch);
        //Debug.Log("カウント" + count);
        //Debug.Log(max);
        //Debug.Log("a"+chpoint[count]);

        if (this.gameObject.tag == "Player")
        {
            PL1_S();
            Debug.Log("1:"+PL1Distance);
        }

        if (this.gameObject.tag == "Player2")
        {
            PL2_S();
            Debug.Log("2:"+PL2Distance);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "Player")
        {
            if (chpoint[count] == other.gameObject)
            {
                if (other.gameObject.tag == "CheckPoint")
                {
                    if (count < max - 1)
                    {
                        count++;
                        score1 -= 1000;
                    }
                }
            }
        }

        if (this.gameObject.tag == "Player2")
        {
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaa");
            if (chpoint[count2] == other.gameObject)
            {
                if (other.gameObject.tag == "CheckPoint")
                {
                    if (count2 < max2 - 1)
                    {
                        count2++;
                        score2 -= 1000;
                    }
                }
            }
        }
    }

    private void PL1_S()
    {
        PL1Distance = Vector3.Distance(this.transform.position, chpoint[count].transform.position);
        PL1Distance += score1;
    }

    private void PL2_S()
    {
        PL2Distance = Vector3.Distance(this.transform.position, chpoint[count2].transform.position);
        PL2Distance += score2;
    }

    private void car_distance()
    {

    }

}
