<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler: MonoBehaviour
{
    //---ゲーム終了処理---
    private void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }
    //---ゲーム終了処理---

    //---GameSceneへ移行---
    public void StartGame()
    {
        SceneManager.LoadScene("aaa");//ゲームシーン名入力
    }
    //---GameSceneへ移行---

    //---SelectSceneへ移行---
    public void PlayerSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
    //---→SelectSceneへ移行---

    //---TitleSceneへ移行---
    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
        Destroy(this);
    }
    //---TitleSceneへ移行---

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);//シーンが移動してもオブジェクトを破棄しないようにする
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler: MonoBehaviour
{
    //---ゲーム終了処理---
    private void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }
    //---ゲーム終了処理---

    //---GameSceneへ移行---
    public void StartGame()
    {
        SceneManager.LoadScene("aaa");//ゲームシーン名入力
    }
    //---GameSceneへ移行---

    //---SelectSceneへ移行---
    public void PlayerSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
    //---→SelectSceneへ移行---

    //---TitleSceneへ移行---
    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
    //---TitleSceneへ移行---

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);//シーンが移動してもオブジェクトを破棄しないようにする
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }
}
>>>>>>> 6a3eca5c6f9e15fb243a09334dcf17dbf1f9bf3f
