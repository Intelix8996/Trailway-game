using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeRotate : MonoBehaviour {

    public int pos;
    public int Deg;


    private void OnMouseDown()
    {
        pos++;
    }

    private void FixedUpdate()
    {
        if (pos == 1)
        {
            Deg = 0;
        }
        if (pos == 2)
        {
            Deg = 90;
        }
        if (pos == 3)
        {
            Deg = 180;
        }
        if (pos == 4)
        {
            Deg = 270;
        }
        if (pos > 4)
        {
            pos = 1;
        }

        transform.rotation = Quaternion.AngleAxis(Deg, Vector3.back);


    }


}
