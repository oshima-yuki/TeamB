using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private GameManeger gm;
    private Vector3[] test = new Vector3[8];
  //  public string objTag;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManeger>();
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Vector3 tPos1 = new Vector3(0f, 3.0f, 0f);
            Vector3 sumPos1 = transform.position + tPos1;
            test[0] = sumPos1;
            gm.lastCheckPointPos[0] = test[0];
        }

        if (col.gameObject.tag == "Player2")
        {
            Vector3 tPos2 = new Vector3(5.0f, 3.0f, 0f);
            Vector3 sumPos2 = transform.position + tPos2;
            test[1] = sumPos2;
            gm.lastCheckPointPos[1] = test[1];
        }

        if (col.gameObject.tag == "Player3")
        {
            Vector3 tPos3 = new Vector3(-5.0f, 3.0f, 0f);
            Vector3 sumPos3 = transform.position + tPos3;
            test[2] = sumPos3;
            gm.lastCheckPointPos[2] = test[2];
        }

        if (col.gameObject.tag == "Player4")
        {
            Vector3 tPos4 = new Vector3(0f, 3.0f, -5.0f);
            Vector3 sumPos4 = transform.position + tPos4;
            test[3] = sumPos4;
            gm.lastCheckPointPos[3] = test[3];
        }

        if (col.gameObject.tag == "Player5")
        {
            Vector3 tPos5 = new Vector3(5.0f, 3.0f, -5.0f);
            Vector3 sumPos5 = transform.position + tPos5;
            test[4] = sumPos5;
            gm.lastCheckPointPos[4] = test[4];
        }

        if (col.gameObject.tag == "Player6")
        {
            Vector3 tPos6 = new Vector3(-5.0f, 3.0f, -5.0f);
            Vector3 sumPos6 = transform.position + tPos6;
            test[5] = sumPos6;
            gm.lastCheckPointPos[5] = test[5];
        }

        if (col.gameObject.tag == "Player7")
        {
            Vector3 tPos7 = new Vector3(0f, 3.0f, -10.0f);
            Vector3 sumPos7 = transform.position + tPos7;
            test[6] = sumPos7;
            gm.lastCheckPointPos[6] = test[6];
        }

        if (col.gameObject.tag == "Player8")
        {
            Vector3 tPos8 = new Vector3(5.0f, 3.0f, -10.0f);
            Vector3 sumPos8 = transform.position + tPos8;
            test[7] = sumPos8;
            gm.lastCheckPointPos[7] = test[7];
        }
    }
}
