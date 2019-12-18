using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_Start_GameSystem : MonoBehaviour
{
    //　スタートボタンを押したら実行する
    public void StartGame()
    {
        SceneManager.LoadScene("Game");//Gameはゲームシーンのスクリプト名に要変更
    }
}
