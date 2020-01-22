using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSINX : MonoBehaviour
{
    public GameObject GameO;
    private float NowTime=0f;
    public float spa=2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        NowTime = Time.deltaTime;
        GameO.transform.Translate(0.05f, 0.02f, 0);
        if (NowTime>spa)
        {
            GameO.transform.Translate(0.05f, -0.06f, 0);
            NowTime = 0f;
        }
    }
}
