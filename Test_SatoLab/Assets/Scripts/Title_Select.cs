using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIコンポーネントの使用

public class Title_Select : MonoBehaviour
{
    //ボタン
    public Button StartButton;
    public Button StartButton_1;

    // Start is called before the first frame update
    void Start()
    {
        // ボタンコンポーネントの取得スクリプトから直接する場合
        //StartButton = GameObject.Find("/TitleWindow/MainPanel/StartButton").GetComponent<Button>();
        //StartButton_1 = GameObject.Find("/TitleWindow/MainPanel/StartButton_1").GetComponent<Button>();

        // 最初に選択状態にしたいボタンの設定
        StartButton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
