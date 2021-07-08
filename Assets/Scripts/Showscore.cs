using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Showscore : MonoBehaviour
{
    public Text FinalScore;

    public void  displayTheScore(int finalScore)
    {
        FinalScore.text = "Score: " + finalScore;
    }
}
