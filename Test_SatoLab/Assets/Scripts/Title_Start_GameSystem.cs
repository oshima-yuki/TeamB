using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Start_GameSystem : MonoBehaviour
{
    //　スタートボタンを押したら実行する
    public void StartGame()
    {
        SceneManager.LoadScene("Game");//Gameはゲームシーンのスクリプト名に要変更
    }
}
