using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{
    public Button button_return;
    public Button button_level1;
    public Button button_level2;
    public Button button_level3;
    public Button button_level4;
    public Button button_level5;
    public Button button_level6;

    private void Awake()
    {
        button_return.onClick.AddListener(OnReturnButtonClick);
        button_level1.onClick.AddListener(OnLevel1ButtonClick);
        button_level2.onClick.AddListener(OnLevel2ButtonClick);
        button_level3.onClick.AddListener(OnLevel3ButtonClick);
        button_level4.onClick.AddListener(OnLevel4ButtonClick);
        button_level5.onClick.AddListener(OnLevel5ButtonClick);
        button_level6.onClick.AddListener(OnLevel6ButtonClick);
    }
    //打开Level1界面
    private void OnLevel1ButtonClick()
    {
        SceneManager.LoadScene("Mao's Residence Map");//Mao's Former Residence
    }
    //打开Level2界面
    private void OnLevel2ButtonClick()
    {
        SceneManager.LoadScene("HuangYangJie_Start");
    }
    //打开Level3界面
    private void OnLevel3ButtonClick()
    {
        SceneManager.LoadScene("Jinggangshan Character");
    }
    //打开Level4界面
    private void OnLevel4ButtonClick()
    {
        SceneManager.LoadScene("JunXieChu");
    }
    //打开Level5界面
    private void OnLevel5ButtonClick()
    {
        SceneManager.LoadScene("Jinggangshan Museum1");
    }
    //打开Level6界面
    private void OnLevel6ButtonClick()
    {
        SceneManager.LoadScene("Jinggangshan Spirits");
    }
    //返回初始界面
    private void OnReturnButtonClick()
    {
        SceneManager.LoadScene("StartUIForSave");
    }
}
