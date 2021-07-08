using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public int score=0;
    public Text scoreText;
    Showscore showscore;

   

    public void Start()
    {
        //showscore = GameObject.Find("ShowScore").GetComponent<Showscore>();
    }
    public void Increment(int value)
    {
        score += value;
        scoreText.text = "Score :" + score;
    }

    public void Show()
    {
        //showscore.displayTheScore(score);
    }
}
