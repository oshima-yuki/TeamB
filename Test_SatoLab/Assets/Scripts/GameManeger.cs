using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

    private static GameManeger instance;
    public Vector3[] lastCheckPointPos = new Vector3[8];

    void setup()
    {
        for(int i = 0; i < 8; i++)
        {
            lastCheckPointPos[i] = Vector3.zero;
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
