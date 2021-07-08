using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject BG, UpperPanel, LowerPanel, MiddlePanel;

    public void ReplayButton()
    {
        SceneManager.LoadScene(0);
    }

    public void menuButton()
    {
        SceneManager.LoadScene(1);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
