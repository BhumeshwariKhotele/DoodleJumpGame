using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Windows;

public class SaveScore : MonoBehaviour
{
    public string pname;
    int score;


    private void Start()
    {
        getPlayerData();
    }

    void SavePlayerData()
    {
        string filePath = Application.persistentDataPath + "/PlayerScore.file";

        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryWriter sw = new BinaryWriter(fs);
        sw.Write(this.pname);
        sw.Write(this.score);
        sw.Close();
        print("----S------A-------V------E-----D-----");
    }

    void getPlayerData()
    {
        string filePath = Application.persistentDataPath + "/PlayerScore.file";

      
        FileStream fs = new FileStream(filePath, FileMode.Open);
        BinaryReader sr = new BinaryReader(fs);
        string PlayerName = sr.ReadString();
        print(PlayerName);
        print("---R---E---T---R---I---E----V---E----D---");
    }
}
