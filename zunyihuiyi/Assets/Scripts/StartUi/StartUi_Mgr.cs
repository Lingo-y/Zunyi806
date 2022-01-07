using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUi_Mgr : MonoBehaviour
{
    public Button startBtn;
    public Button helpBtn;
    public Button introBtn;
    public Button exitBtn;
    public Button helpRetBtn;
    public Button introRetBtn;

    public GameObject uiHelp;
    public GameObject uiIntro;

    public string nextScene;
   
    void Start()
    {
        startBtn.onClick.AddListener(ClickStart);
        helpBtn.onClick.AddListener(ClickHelp);
        introBtn.onClick.AddListener(ClickIntro);
        exitBtn.onClick.AddListener(ClickExit);
        helpRetBtn.onClick.AddListener(ClickhelpRet);
        introRetBtn.onClick.AddListener(ClickintroRet);
    }

    void ClickStart() {
        LoadNextLevel();
    }

    void ClickHelp() {
        uiHelp.SetActive(true);
    }

    void ClickIntro() {
        uiIntro.SetActive(true);
    }

    void ClickExit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;            
        #else
        Application.Quit();
        #endif

    }

    void ClickhelpRet()
    {
        uiHelp.SetActive(false);
    }

    void ClickintroRet()
    {
        uiIntro.SetActive(false);
    }

    void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel() {
        AsyncOperation operation = SceneManager.LoadSceneAsync(nextScene);
        operation.allowSceneActivation = true;
        yield return null;
    }

}
