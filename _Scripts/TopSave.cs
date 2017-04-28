using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TopSave : MonoBehaviour {

    public Text Timer;

    public String FileSave = "Saves/Top.txt";
    public String FileSave2 = "Logs/Log.txt";
    public String FileSaveServer = "";
    public String FileSaveServer2 = "";

    public int milsec = 0;
    public int sec = 0;
    public int min = 0;
    public int Score = 0;

    public bool GameEnd = false;

    public WinDetecter WinDet;

    private void Start()
    {
        WinDet = GetComponent<WinDetecter>();

        StreamReader ReadPathServLog = new StreamReader("Config/ServerLogsConf.txt");

        if (ReadPathServLog.ReadLine() == "enabled")
        {
            FileSaveServer = ReadPathServLog.ReadLine();
        }else
        {
            ReadPathServLog.ReadLine();
        }
        ReadPathServLog.ReadLine();
        if (ReadPathServLog.ReadLine() == "enabled")
        {
            FileSaveServer2 = ReadPathServLog.ReadLine();
        }
        else
        {
            ReadPathServLog.ReadLine();
        }
    }

    private void FixedUpdate()
    {
        milsec++;
        sec = milsec / 50;

        if (sec == 60)
        {
            sec = 1;
            milsec = 0;
            min++;
        }

        if (!GameEnd)
        {
            Timer.text = "Время: " + Convert.ToString(min) + ":" + Convert.ToString(sec);
        }

        Score++;
    }

    public void Save(string _name, int _Score)
    {
        FileSave = "Saves/" + _name + ".txt";

        StreamWriter SaveData = new StreamWriter(FileSave, true);

        SaveData.WriteLine("");
        SaveData.WriteLine("---------------------");
        SaveData.WriteLine("Date: " + System.DateTime.Now);
        SaveData.WriteLine("Name: " + _name);
        SaveData.WriteLine("Score: " + _Score);
        SaveData.WriteLine("Time: " + Convert.ToString(min) + ":" + Convert.ToString(sec));
        SaveData.WriteLine("Size: " + WinDet._Size);
        SaveData.WriteLine("Difficulty: " + WinDet._Difficulty / 2);
        SaveData.WriteLine("---------------------");
        SaveData.WriteLine("");
        SaveData.Close();

        StreamWriter SaveData2 = new StreamWriter(FileSave2, true);

        SaveData2.WriteLine("");
        SaveData2.WriteLine("---------------------");
        SaveData2.WriteLine("Date: " + System.DateTime.Now);
        SaveData2.WriteLine("Name: " + _name);
        SaveData2.WriteLine("Score: " + _Score);
        SaveData2.WriteLine("Time: " + Convert.ToString(min) + ":" + Convert.ToString(sec));
        SaveData2.WriteLine("Size: " + WinDet._Size);
        SaveData2.WriteLine("Difficulty: " + WinDet._Difficulty / 2);
        SaveData2.WriteLine("---------------------");
        SaveData2.WriteLine("");
        SaveData2.Close();
    }

    public void SaveServer (string _name, int _Score)
    {
        FileSaveServer = FileSaveServer + _name + ".txt";

        StreamWriter SaveDataServer = new StreamWriter(FileSaveServer, true);

        SaveDataServer.WriteLine("");
        SaveDataServer.WriteLine("---------------------");
        SaveDataServer.WriteLine("Date: " + System.DateTime.Now);
        SaveDataServer.WriteLine("Name: " + _name);
        SaveDataServer.WriteLine("Score: " + _Score);
        SaveDataServer.WriteLine("Time: " + Convert.ToString(min) + ":" + Convert.ToString(sec));
        SaveDataServer.WriteLine("Size: " + WinDet._Size);
        SaveDataServer.WriteLine("Difficulty: " + WinDet._Difficulty / 2);
        SaveDataServer.WriteLine("---------------------");
        SaveDataServer.WriteLine("");
        SaveDataServer.Close();

        StreamWriter SaveDataServer2 = new StreamWriter(FileSaveServer2, true);

        SaveDataServer2.WriteLine("");
        SaveDataServer2.WriteLine("---------------------");
        SaveDataServer2.WriteLine("Date: " + System.DateTime.Now);
        SaveDataServer2.WriteLine("Name: " + _name);
        SaveDataServer2.WriteLine("Score: " + _Score);
        SaveDataServer2.WriteLine("Time: " + Convert.ToString(min) + ":" + Convert.ToString(sec));
        SaveDataServer2.WriteLine("Size: " + WinDet._Size);
        SaveDataServer2.WriteLine("Difficulty: " + WinDet._Difficulty / 2);
        SaveDataServer2.WriteLine("---------------------");
        SaveDataServer2.WriteLine("");
        SaveDataServer2.Close();
    }

}
