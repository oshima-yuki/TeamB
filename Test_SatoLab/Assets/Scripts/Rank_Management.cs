using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank_Management : MonoBehaviour
{
    static int P1;//Player１
    static int P2;
    static int P3;
    public GameObject rank_object;//テキストを取得
    private int rank = 0;//順位のテキスト表示

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        P1 = CarCheck.GetPC1() + Goal.GetPC1();//ゴールした時にGoalのスクリプトから数字をたす
        //Debug.Log();
        P2 = CarCheck.GetPC2() + Goal.GetPC2();
        P3 = CarCheck.GetPC3() + Goal.GetPC3();

        if (P1 > P2 && P1 > P3)
        {
            rank = 1;
           // Debug.Log("1st");
        }
        else if ((P1 < P2 && P1 > P3) || (P1 < P3 && P1 > P2))
        {
            rank = 2;
            //Debug.Log("2nd");
        }
        else if (P1 < P2 && P1 < P3)
        {
            rank = 3;
           //Debug.Log("3rd");
        }

        Text rank_text = rank_object.GetComponent<Text>();
        rank_text.text = rank + "位";
    }

}
