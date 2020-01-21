using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car_Distance : MonoBehaviour
{

    public GameObject[] Player;
    float PL1D;
    public float timeCount = 1.5f;
    public int Array_Count;
    static int AC;
    public GameObject rank_object;
    private int rank = 0;

    public static int P1AC()
    {
        return AC;
    }

    // Start is called before the first frame update
    void Start()
    {
        AC = Array_Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Car_Pass.PL1Distance < Car_Pass.PL2Distance)
        {
            rank = 1;
        }
        else if (Car_Pass.PL1Distance > Car_Pass.PL2Distance)
        {
            rank = 2;
        }

        Text rank_text = rank_object.GetComponent<Text>();
        rank_text.text = rank + "位";
    }


}
