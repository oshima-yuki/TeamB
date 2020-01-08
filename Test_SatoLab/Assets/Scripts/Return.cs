using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{

    //private readonly int frame = 0;
    private float time = 0.0f;
    public GameObject explode;//explodeにはunity上でprefabを関連付けます
    public string RTagname;

    //対象のオブジェクト
    public GameObject desObj;
    private bool isRespon = false;
    private Vector3 initPos;
    private Resporn resporn;

    // Use this for initialization 
    void Start()
    {
        //初期値設定 
        this.initPos = Vector3.zero;
    }
    // Update is called once per frame 
    void Update()
    {

        if (isRespon)
        {
            time += Time.deltaTime;
            if (time >= 3.0f)
            {
                time = 0.0f;
                isRespon = false;
                this.desObj.SetActive(true);
                this.desObj.transform.position = initPos;
            }
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == RTagname)
        {
            this.desObj.SetActive(false);
            Instantiate(explode, this.desObj.transform.position, Quaternion.identity);
            isRespon = true;
            //または
            //coll.gameObject.SetActive(false);
        }

       
    }

}