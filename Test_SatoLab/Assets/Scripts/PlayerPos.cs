using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private GameManeger gm;
    public int x;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManeger>();
        transform.position = gm.lastCheckPointPos[x];
        transform.rotation = gm.lastCheckPointRot[x];
    }

    // Update is called once per frame
    void Update()
    {
    }
}
