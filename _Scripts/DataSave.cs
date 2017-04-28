using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSave : MonoBehaviour {

    public UIManadger Root;
    public float ChanceTrnsm;
    public int _SizeValue;
    public string PlName;

    private void FixedUpdate()
    {
        PlName = Root._name.text;
        ChanceTrnsm = Root.CanceNumProg2;
        _SizeValue = Root.SizeValue;
        DontDestroyOnLoad(this);
    }

}
