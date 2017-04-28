using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinDetecter : MonoBehaviour {

    public Text Wintext;
    public Text Wintext2;
    public Text WinScore;
    public TopSave DataSaver;
    private GameObject StartPoint;
    public GameObject Taker;

    public int _Score = 0;
    public int _Size = 0;
    public float _Difficulty = 0;

    private void Start()
    {
        DataSaver = GetComponent<TopSave>();
        Taker = GameObject.FindGameObjectWithTag("Transm");

        _Size = Taker.GetComponent<DataSave>()._SizeValue;
        _Difficulty = Taker.GetComponent<DataSave>().ChanceTrnsm;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.tag == "PlayerInt")
        {
            DataSaver.GameEnd = true;
            _Score = 1000000 / (DataSaver.min * 60 + DataSaver.sec + DataSaver.milsec);
            Wintext.GetComponent<Text>().enabled = true;
            Wintext.GetComponent<Animator>().enabled = true;
            Wintext2.GetComponent<Text>().enabled = true;
            WinScore.GetComponent<Text>().enabled = true;
            WinScore.text = "Счёт: " + _Score;
            DataSaver.Save(Taker.GetComponent<DataSave>().PlName, _Score);

            if (DataSaver.FileSaveServer != "")
            {
                DataSaver.SaveServer(Taker.GetComponent<DataSave>().PlName, _Score);
            }
        }

    }

    private void FixedUpdate()
    {
        StartPoint = GameObject.FindGameObjectWithTag("Start");
        transform.position = StartPoint.transform.position;
    }
}
