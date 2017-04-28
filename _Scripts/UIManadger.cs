using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManadger : MonoBehaviour {

    public Dropdown Size;
    public Scrollbar Chance;
    public float CanceNumProg;
    public float CanceNumProg2;
    public float CanceNumUser2;
    public int SizeValue;
    public Text CanceNumUser;
    public InputField _name;

    private void FixedUpdate()
    {
        CanceNumProg = Chance.value;
        CanceNumUser2 = CanceNumProg * 1000;
        CanceNumProg2 = CanceNumProg * 2000;
        CanceNumUser.text = "Шанс:" + Convert.ToInt16(CanceNumUser2) + " из 1000";
        SizeValue = Size.value;
    }

}
