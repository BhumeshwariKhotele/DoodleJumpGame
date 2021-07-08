using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{
    public GameObject BGPanel, BottomPanel, SettingPanel, TutorialPanel,ScorePanel;
    public GameObject MiddlePanel, TopPanel;
   
    public void startGame()
    {
        SceneManager.LoadScene(0);
    }

    public void SettingButton()
    {
        BGPanel.SetActive(true);
        SettingPanel.SetActive(true);
        MiddlePanel.SetActive(false);
        TutorialPanel.SetActive(false);
        BottomPanel.SetActive(false);
        ScorePanel.SetActive(false);
        TopPanel.SetActive(false);
    }

    public void TutorialButton()
    {
        BGPanel.SetActive(true);
        SettingPanel.SetActive(false);
        MiddlePanel.SetActive(false);
        TutorialPanel.SetActive(true);
        BottomPanel.SetActive(false);
        ScorePanel.SetActive(false);
        TopPanel.SetActive(false);
    }

    public void ScoreButton()
    {
        BGPanel.SetActive(true);
        SettingPanel.SetActive(false);
        MiddlePanel.SetActive(false);
        TutorialPanel.SetActive(false);
        BottomPanel.SetActive(false);
        ScorePanel.SetActive(true);
        TopPanel.SetActive(false);
    }


    public void BackButton()
    {
        BGPanel.SetActive(true);
        SettingPanel.SetActive(false);
        MiddlePanel.SetActive(true);
        TutorialPanel.SetActive(false);
        BottomPanel.SetActive(true);
        ScorePanel.SetActive(false);
        TopPanel.SetActive(true);
    }
   
    

    public void MusicON()
    {
        AudioListener.pause = true;
    }

    public void MusicOFF()
    {
        AudioListener.pause = false;
    }

}



















