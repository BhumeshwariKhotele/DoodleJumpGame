using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Showscore : MonoBehaviour
{
    public Text FinalScore;
    int finalScore;
  
    void  Start()
    {
        finalScore = PlayerPrefs.GetInt("PlayerScore");
        FinalScore.text = "Score: " + finalScore;
    }
}
