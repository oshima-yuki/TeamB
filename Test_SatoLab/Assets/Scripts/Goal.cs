using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    static int First;
    static int Second;
    static int Third;

    int Count=10;//ゴールした時に数字をたす

    bool flag1 = true;
    bool flag2 = true;
    bool flag3 = true;

    static int P1Point = 0;//rank_Managementに数字を送る
    static int P2Point = 0;
    static int P3Point = 0;

    //static int Rank = 10;


    // Start is called before the first frame update

    public static int GetPC1()
    {
        return P1Point;
    }

    public static int GetPC2()
    {
        return P2Point;
    }

    public static int GetPC3()
    {
        return P3Point;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && flag1 == true)
        {
            P1Point += Count;
            Count = Count - 1;
            //Debug.Log(Count);
            flag1 = false;
            Debug.Log("P1ゴール");
        }

        if (other.gameObject.tag == "Player2" && flag2 == true)
        {
            P2Point += Count;
            Count = Count - 1;
            flag2 = false;
            Debug.Log("P2ゴール");
        }

        if (other.gameObject.tag == "Player3" && flag3 == true)
        {
            P3Point += Count;
            Count = Count - 1;
            flag3 = false;
            Debug.Log("P3ゴール");
        }
    }

}
