using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_manager : MonoBehaviour
{
    public static bool start;
    public static bool goal;

    // Start is called before the first frame update
    void Start()
    {
        start = false;
        goal = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(start);
    }
}
