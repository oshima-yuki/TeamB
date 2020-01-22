using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{

    //private readonly int frame = 0;
    public float time = 0.0f;
    public GameObject explode;//explodeにはunity上でprefabを関連付けます
    //public string RTagname;
    private GameManeger gm;

    //対象のオブジェクト
    private bool[] isRespon = { false, false, false, false, false, false, false, false };
    public GameObject[] desObjs = new GameObject[8];
    public Vector3[] initPos = new Vector3[8];
    public int l = 0;

    // Use this for initialization 
    void Start()
    {
        //初期値設定 
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManeger>();
        for(int i = 0; i < l; i++) { this.initPos[i] = gm.lastCheckPointPos[i]; }
        
    }
    // Update is called once per frame 
    void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            if (isRespon[i])//Playerzzzzz
            {
                time += Time.deltaTime;
                if (time >= 3.0f)
                {

                    time = 0.0f;
                    isRespon[i] = false;
                    this.desObjs[i].SetActive(true);
                    this.desObjs[i].transform.position = gm.lastCheckPointPos[i];
                    this.desObjs[i].transform.rotation = gm.lastCheckPointRot[i];
                    
                }
            }

        }
    }

    

    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")//Player
        {
            this.desObjs[0].SetActive(false);
            Instantiate(explode, this.desObjs[0].transform.position, Quaternion.identity);
            isRespon[0] = true;
        }

        if (coll.gameObject.tag == "Player2")//Player2
        {
            this.desObjs[1].SetActive(false);
            Instantiate(explode, this.desObjs[1].transform.position, Quaternion.identity);
            isRespon[1] = true;
        }

        if (coll.gameObject.tag == "Player3")//Player3
        {
            this.desObjs[2].SetActive(false);
            Instantiate(explode, this.desObjs[2].transform.position, Quaternion.identity);
            isRespon[2] = true;
        }

        if (coll.gameObject.tag == "Player4")//Player4
        {
            this.desObjs[3].SetActive(false);
            Instantiate(explode, this.desObjs[3].transform.position, Quaternion.identity);
            isRespon[3] = true;
        }

        if (coll.gameObject.tag == "Player5")//Player5
        {
            this.desObjs[4].SetActive(false);
            Instantiate(explode, this.desObjs[4].transform.position, Quaternion.identity);
            isRespon[4] = true;
        }

        if (coll.gameObject.tag == "Player6")//Player6
        {
            this.desObjs[5].SetActive(false);
            Instantiate(explode, this.desObjs[5].transform.position, Quaternion.identity);
            isRespon[5] = true;
        }

        if (coll.gameObject.tag == "Player7")//Player7
        {
            this.desObjs[6].SetActive(false);
            Instantiate(explode, this.desObjs[6].transform.position, Quaternion.identity);
            isRespon[6] = true;
        }

        if (coll.gameObject.tag == "Player8")//Player8
        {
            this.desObjs[7].SetActive(false);
            Instantiate(explode, this.desObjs[7].transform.position, Quaternion.identity);
            isRespon[7] = true;
        }
    }

}