using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

    private static GameManeger instance;
    public Vector3[] lastCheckPointPos = new Vector3[8];
    public Quaternion[] lastCheckPointRot = new Quaternion[8];

    void setup()
    {
        for(int i = 0; i < 8; i++)
        {
            lastCheckPointPos[i] = Vector3.zero;
            lastCheckPointRot[i] = Quaternion.Euler(0,0,0);
        }
    }
    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
