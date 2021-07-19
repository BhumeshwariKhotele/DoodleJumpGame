using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Score : MonoBehaviour
{
    public int score=0;
    public Text scoreText;
    

    public void Increment(int value)
    {
        score += value;
        scoreText.text = "Score :" + score;
    }
  
    public void SaveScore()
    {
        Debug.Log(score);
        PlayerPrefs.SetInt("PlayerScore", score);
    }
}