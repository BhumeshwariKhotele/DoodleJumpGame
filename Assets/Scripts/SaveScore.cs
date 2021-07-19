using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Windows;
using UnityEngine.UI;

public class SaveScore : MonoBehaviour
{
    [SerializeField] string PlayerName;
    [SerializeField] int PlayerAge;
    [SerializeField] int PlayerScore;

    [SerializeField] Text playerName;
    [SerializeField] Text playerAge;
    [SerializeField] Text playerScore;

    private void Start()
    {
        getPlayerData();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SavePlayerData();
        }
    }

    void SavePlayerData()
    {
        string filePath = Application.persistentDataPath + "/PlayerScoreData.file";
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryWriter sw = new BinaryWriter(fs);
      
        sw.Write(this.PlayerName);
        sw.Write(this.PlayerAge);
        sw.Write(PlayerPrefs.GetInt("PlayerScore"));
        sw.Close();
        
        print("----S------A-------V------E-----D-----");
    }

    void getPlayerData()
    {
        string filePath = Application.persistentDataPath + "/PlayerScoreData.file";
        FileStream fs = new FileStream(filePath, FileMode.Open);
        BinaryReader sr = new BinaryReader(fs);
      
        string pName = sr.ReadString();
        int pAge = sr.ReadInt32();
        int pScore = sr.ReadInt32();
      
        playerName.text = "Player :" + pName;
        playerAge.text = "Age :" + pAge;
        playerScore.text = "Score :" + pScore;
      
        sr.Close();

        print("---R---E---T---R---I---E----V---E----D---");
    }
}
