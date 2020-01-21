using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resporn : MonoBehaviour
{
    public Vector3 rePos;
    GameObject test;
    public GameObject Player;
    public GameObject desObj;
    public float time = 0.0f;

    GameObject[] Rsporn = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.FindWithTag("Wall");
        Rsporn[0] = GameObject.Find("checkpoint1");
        Rsporn[1] = GameObject.Find("checkpoint2");
        Rsporn[2] = GameObject.Find("checkpoint3");
        Rsporn[3] = GameObject.Find("checkpoint4");
        Rsporn[4] = GameObject.Find("checkpoint5");

        rePos = Rsporn[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // GameManeger PlayerResporn = test.GetComponent<GameManeger>();
        if(Player)
        {

        }
        else
        {
            time += Time.deltaTime;
            if (time >= 3.0f)
            {
                time = 0.0f;
                this.Player.SetActive(true);
                this.Player.transform.position = rePos;
            }
        }
    }

    public void OnTrigger(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            for (int i = 0; i < 5; i++)
            {
                rePos = Rsporn[i].transform.position;
            }
        }


    }

}
