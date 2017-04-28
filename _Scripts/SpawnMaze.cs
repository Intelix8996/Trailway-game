using UnityEngine;

public class SpawnMaze : MonoBehaviour
{

    public GameObject MazePartL;
    public GameObject MazePartT;
    private GameObject MazePartProg;
    public GameObject Taker;
    public GameObject StartPointDown;
    public GameObject StartPointUp;
    public GameObject StartPointRight;
    public GameObject StartPointLeft;
    public GameObject EndPointDown;
    public GameObject EndPointUp;
    public GameObject EndPointRight;
    public GameObject EndPointLeft;
    public GameObject Character;
    public GameObject Border;
    public GameObject Background;
    public GameObject Camera;
    public int ObjSkinPoint;
    public int CountX = 0;
    public int CountY = 0;
    public float x2 = 0;
    public float x3 = 0;
    public float x5 = 0;
    public float x6 = 0;
    public float x7 = 0;
    public float x8 = 0;
    public int StrPnt;
    public int EndPnt;

    private void Start()
    {
        Taker = GameObject.FindGameObjectWithTag("Transm");

        switch (Taker.GetComponent<DataSave>()._SizeValue)
        {
            case 0:
                StrPnt = Random.Range(1, 13);
                EndPnt = Random.Range(1, 13);

                if (EndPnt == StrPnt)
                {
                    EndPnt = Random.Range(1, 13);
                }

                switch (StrPnt)
                {
                    case 1:
                        x5 = -2.4f;
                        x6 = 1.2f;
                        break;
                    case 2:
                        x5 = -1.2f;
                        x6 = 1.2f;
                        break;
                    case 3:
                        x5 = 0;
                        x6 = 1.2f;
                        break;
                    case 4:
                        x5 = 1.2f;
                        x6 = 0;
                        break;
                    case 5:
                        x5 = 0;
                        x6 = -3.6f;
                        break;
                    case 6:
                        x5 = 1.2f;
                        x6 = -1.2f;
                        break;
                    case 7:
                        x5 = 1.2f;
                        x6 = -2.4f;
                        break;
                    case 8:
                        x5 = -1.2f;
                        x6 = -3.6f;
                        break;
                    case 9:
                        x5 = -2.4f;
                        x6 = -3.6f;
                        break;
                    case 10:
                        x5 = -3.6f;
                        x6 = -2.4f;
                        break;
                    case 11:
                        x5 = -3.6f;
                        x6 = -1.2f;
                        break;
                    case 12:
                        x5 = -3.6f;
                        x6 = 0f;
                        break;
                }


                switch (EndPnt)
                {
                    case 1:
                        x7 = -2.4f;
                        x8 = 1.2f;
                        break;
                    case 2:
                        x7 = -1.2f;
                        x8 = 1.2f;
                        break;
                    case 3:
                        x7 = 0;
                        x8 = 1.2f;
                        break;
                    case 4:
                        x7 = 1.2f;
                        x8 = 0;
                        break;
                    case 5:
                        x7 = 0;
                        x8 = -3.6f;
                        break;
                    case 6:
                        x7 = 1.2f;
                        x8 = -1.2f;
                        break;
                    case 7:
                        x7 = 1.2f;
                        x8 = -2.4f;
                        break;
                    case 8:
                        x7 = -1.2f;
                        x8 = -3.6f;
                        break;
                    case 9:
                        x7 = -2.4f;
                        x8 = -3.6f;
                        break;
                    case 10:
                        x7 = -3.6f;
                        x8 = -2.4f;
                        break;
                    case 11:
                        x7 = -3.6f;
                        x8 = -1.2f;
                        break;
                    case 12:
                        x7 = -3.6f;
                        x8 = 0f;
                        break;
                }
                break;

            case 1:
                StrPnt = Random.Range(1, 17);
                EndPnt = Random.Range(1, 17);

                if (EndPnt == StrPnt)
                {
                    EndPnt = Random.Range(1, 17);
                }

                switch (StrPnt)
                {
                    case 1:
                        x5 = -3.6f;
                        x6 = 1.2f;
                        break;
                    case 2:
                        x5 = -2.4f;
                        x6 = 1.2f;
                        break;
                    case 3:
                        x5 = -1.2f;
                        x6 = 1.2f;
                        break;
                    case 4:
                        x5 = 0;
                        x6 = 1.2f;
                        break;
                    case 5:
                        x5 = 1.2f;
                        x6 = 0;
                        break;
                    case 6:
                        x5 = 1.2f;
                        x6 = -1.2f;
                        break;
                    case 7:
                        x5 = 1.2f;
                        x6 = -2.4f;
                        break;
                    case 8:
                        x5 = 1.2f;
                        x6 = -2.4f;
                        break;
                    case 9:
                        x5 = 1.2f;
                        x6 = -3.6f;
                        break;
                    case 10:
                        x5 = 0;
                        x6 = -4.8f;
                        break;
                    case 11:
                        x5 = -1.2f;
                        x6 = -4.8f;
                        break;
                    case 12:
                        x5 = -2.4f;
                        x6 = -4.8f;
                        break;
                    case 13:
                        x5 = -3.6f;
                        x6 = -4.8f;
                        break;
                    case 14:
                        x5 = -4.8f;
                        x6 = -3.6f;
                        break;
                    case 15:
                        x5 = -4.8f;
                        x6 = -2.4f;
                        break;
                    case 16:
                        x5 = -4.8f;
                        x6 = -1.2f;
                        break;
                    case 17:
                        x5 = -4.8f;
                        x6 = 0f;
                        break;
                }


                switch (EndPnt)
                {
                    case 1:
                        x7 = -3.6f;
                        x8 = 1.2f;
                        break;
                    case 2:
                        x7 = -2.4f;
                        x8 = 1.2f;
                        break;
                    case 3:
                        x7 = -1.2f;
                        x8 = 1.2f;
                        break;
                    case 4:
                        x7 = 0;
                        x8 = 1.2f;
                        break;
                    case 5:
                        x7 = 1.2f;
                        x8 = 0;
                        break;
                    case 6:
                        x7 = 1.2f;
                        x8 = -1.2f;
                        break;
                    case 7:
                        x7 = 1.2f;
                        x8 = -2.4f;
                        break;
                    case 8:
                        x7 = 1.2f;
                        x8 = -2.4f;
                        break;
                    case 9:
                        x7 = 1.2f;
                        x8 = -3.6f;
                        break;
                    case 10:
                        x7 = 0;
                        x8 = -4.8f;
                        break;
                    case 11:
                        x7 = -1.2f;
                        x8 = -4.8f;
                        break;
                    case 12:
                        x7 = -2.4f;
                        x8 = -4.8f;
                        break;
                    case 13:
                        x7 = -3.6f;
                        x8 = -4.8f;
                        break;
                    case 14:
                        x7 = -4.8f;
                        x8 = -3.6f;
                        break;
                    case 15:
                        x7 = -4.8f;
                        x8 = -2.4f;
                        break;
                    case 16:
                        x7 = -4.8f;
                        x8 = -1.2f;
                        break;
                    case 17:
                        x7 = -4.8f;
                        x8 = 0f;
                        break;
                }
                break;

            case 2:
                StrPnt = Random.Range(1, 20);
                EndPnt = Random.Range(1, 20);

                if (EndPnt == StrPnt)
                {
                    EndPnt = Random.Range(1, 13);
                }

                switch (StrPnt)
                {
                    case 1:
                        x5 = -4.8f;
                        x6 = 1.2f;
                        break;
                    case 2:
                        x5 = -3.6f;
                        x6 = 1.2f;
                        break;
                    case 3:
                        x5 = -2.4f;
                        x6 = 1.2f;
                        break;
                    case 4:
                        x5 = -1.2f;
                        x6 = 1.2f;
                        break;
                    case 5:
                        x5 = 0;
                        x6 = 1.2f;
                        break;
                    case 6:
                        x5 = 1.2f;
                        x6 = 0;
                        break;
                    case 7:
                        x5 = 1.2f;
                        x6 = -1.2f;
                        break;
                    case 8:
                        x5 = 1.2f;
                        x6 = -2.4f;
                        break;
                    case 9:
                        x5 = 1.2f;
                        x6 = -3.6f;
                        break;
                    case 10:
                        x5 = 1.2f;
                        x6 = -4.8f;
                        break;
                    case 11:
                        x5 = 0;
                        x6 = -6f;
                        break;
                    case 12:
                        x5 = -1.2f;
                        x6 = -6f;
                        break;
                    case 13:
                        x5 = -2.4f;
                        x6 = -6f;
                        break;
                    case 14:
                        x5 = -3.6f;
                        x6 = -6f;
                        break;
                    case 15:
                        x5 = -4.8f;
                        x6 = -6f;
                        break;
                    case 16:
                        x5 = -6f;
                        x6 = -4.8f;
                        break;
                    case 17:
                        x5 = -6f;
                        x6 = -3.6f;
                        break;
                    case 18:
                        x5 = -6f;
                        x6 = -2.4f;
                        break;
                    case 19:
                        x5 = -6f;
                        x6 = -1.2f;
                        break;
                    case 20:
                        x5 = -6f;
                        x6 = 0f;
                        break;
                }


                switch (EndPnt)
                {
                    case 1:
                        x7 = -4.8f;
                        x8 = 1.2f;
                        break;
                    case 2:
                        x7 = -3.6f;
                        x8 = 1.2f;
                        break;
                    case 3:
                        x7 = -2.4f;
                        x8 = 1.2f;
                        break;
                    case 4:
                        x7 = -1.2f;
                        x8 = 1.2f;
                        break;
                    case 5:
                        x7 = 0;
                        x8 = 1.2f;
                        break;
                    case 6:
                        x7 = 1.2f;
                        x8 = 0;
                        break;
                    case 7:
                        x7 = 1.2f;
                        x8 = -1.2f;
                        break;
                    case 8:
                        x7 = 1.2f;
                        x8 = -2.4f;
                        break;
                    case 9:
                        x7 = 1.2f;
                        x8 = -3.6f;
                        break;
                    case 10:
                        x7 = 1.2f;
                        x8 = -4.8f;
                        break;
                    case 11:
                        x7 = 0;
                        x8 = -6f;
                        break;
                    case 12:
                        x7 = -1.2f;
                        x8 = -6f;
                        break;
                    case 13:
                        x7 = -2.4f;
                        x8 = -6f;
                        break;
                    case 14:
                        x7 = -3.6f;
                        x8 = -6f;
                        break;
                    case 15:
                        x7 = -4.8f;
                        x8 = -6f;
                        break;
                    case 16:
                        x7 = -6f;
                        x8 = -4.8f;
                        break;
                    case 17:
                        x7 = -6f;
                        x8 = -3.6f;
                        break;
                    case 18:
                        x7 = -6f;
                        x8 = -2.4f;
                        break;
                    case 19:
                        x7 = -6f;
                        x8 = -1.2f;
                        break;
                    case 20:
                        x7 = -6f;
                        x8 = 0f;
                        break;
                }
                break;

        }

        switch (Taker.GetComponent<DataSave>()._SizeValue)
        {
            case 0:
                if (x8 == 1.2f)
                {
                    Instantiate(StartPointUp, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x8 == -3.6f)
                {
                    Instantiate(StartPointDown, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x7 == -3.6f)
                {
                    Instantiate(StartPointLeft, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x7 == 1.2f)
                {
                    Instantiate(StartPointRight, new Vector3(x7, x8, 1), Quaternion.identity);
                }


                if (x6 == 1.2f)
                {
                    Instantiate(EndPointUp, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x6 == -3.6f)
                {
                    Instantiate(EndPointDown, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x5 == -3.6f)
                {
                    Instantiate(EndPointLeft, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x5 == 1.2f)
                {
                    Instantiate(EndPointRight, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                break;

            case 1:
                if (x8 == 1.2f)
                {
                    Instantiate(StartPointUp, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x8 == -4.8f)
                {
                    Instantiate(StartPointDown, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x7 == -4.8f)
                {
                    Instantiate(StartPointLeft, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x7 == 1.2f)
                {
                    Instantiate(StartPointRight, new Vector3(x7, x8, 1), Quaternion.identity);
                }


                if (x6 == 1.2f)
                {
                    Instantiate(EndPointUp, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x6 == -4.8f)
                {
                    Instantiate(EndPointDown, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x5 == -4.8f)
                {
                    Instantiate(EndPointLeft, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x5 == 1.2f)
                {
                    Instantiate(EndPointRight, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                break;

            case 2:
                if (x8 == 1.2f)
                {
                    Instantiate(StartPointUp, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x8 == -6f)
                {
                    Instantiate(StartPointDown, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x7 == -6f)
                {
                    Instantiate(StartPointLeft, new Vector3(x7, x8, 1), Quaternion.identity);
                }
                if (x7 == 1.2f)
                {
                    Instantiate(StartPointRight, new Vector3(x7, x8, 1), Quaternion.identity);
                }


                if (x6 == 1.2f)
                {
                    Instantiate(EndPointUp, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x6 == -6f)
                {
                    Instantiate(EndPointDown, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x5 == -6f)
                {
                    Instantiate(EndPointLeft, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                if (x5 == 1.2f)
                {
                    Instantiate(EndPointRight, new Vector3(x5, x6, 1), Quaternion.identity);
                }
                break;
        }

        switch (Taker.GetComponent<DataSave>()._SizeValue)
        {
            case 0:
                Instantiate(Character, new Vector3(x7, x8, 1), Quaternion.identity);
                Instantiate(Border, new Vector3(-0.95f, -1.15f, 1), Quaternion.identity);
                Instantiate(Background, new Vector3(-1.28f, -1.56f, 2), Quaternion.identity);
                break;
            case 1:
                Instantiate(Character, new Vector3(x7, x8, 1), Quaternion.identity);
                Border.transform.localScale = new Vector3(1.55f, 1.55f, 1);
                Instantiate(Border, new Vector3(-1.85f, -1.85f, 1), Quaternion.identity);
                Background.transform.localScale = new Vector3(2.2f, 2.2f, 1);
                Instantiate(Background, new Vector3(-1.6f, -1.6f, 2.5f), Quaternion.identity);
                break;
            case 2:
                Instantiate(Character, new Vector3(x7, x8, 1), Quaternion.identity);
                Border.transform.localScale = new Vector3(1.8f, 1.8f, 1);
                Instantiate(Border, new Vector3(-2.4f, -2.35f, 1), Quaternion.identity);
                Background.transform.localScale = new Vector3(2.5f, 2.5f, 1);
                Instantiate(Background, new Vector3(-2.6f, -3.9f, 2.5f), Quaternion.identity);
                break;

        }
    }

    private void FixedUpdate()
    {
        float Chnc = Taker.GetComponent<DataSave>().ChanceTrnsm;

        switch (Taker.GetComponent<DataSave>()._SizeValue)
        {
            case 0:
                while (CountY < 3)
                {
                    while (CountX < 3)
                    {
                        ObjSkinPoint = Random.Range(1, 2000);

                        if (ObjSkinPoint < Chnc)
                        {
                            MazePartProg = MazePartT;
                        }
                        else
                        {
                            MazePartProg = MazePartL;
                        }

                        Instantiate(MazePartProg, new Vector3(x2, x3, 1), Quaternion.identity);
                        x2 += -1.2f;
                        CountX++;
                    }
                    x2 = 0;
                    CountX = 0;
                    x3 += -1.2f;
                    CountY++;
                }
                Camera.transform.position = new Vector3(-1.27f, -1.2f, -4.3f);
                break;
            case 1:
                while (CountY < 4)
                {
                    while (CountX < 4)
                    {
                        ObjSkinPoint = Random.Range(1, 2000);

                        if (ObjSkinPoint < Chnc)
                        {
                            MazePartProg = MazePartT;
                        }
                        else
                        {
                            MazePartProg = MazePartL;
                        }

                        Instantiate(MazePartProg, new Vector3(x2, x3, 1), Quaternion.identity);
                        x2 += -1.2f;
                        CountX++;
                    }
                    x2 = 0;
                    CountX = 0;
                    x3 += -1.2f;
                    CountY++;
                }
                Camera.transform.position = new Vector3(-1.75f, -1.75f, -5.1f);
                break;
            case 2:
                while (CountY < 5)
                {
                    while (CountX < 5)
                    {
                        ObjSkinPoint = Random.Range(1, 2000);

                        if (ObjSkinPoint < Chnc)
                        {
                            MazePartProg = MazePartT;
                        }
                        else
                        {
                            MazePartProg = MazePartL;
                        }

                        Instantiate(MazePartProg, new Vector3(x2, x3, 1), Quaternion.identity);
                        x2 += -1.2f;
                        CountX++;
                    }
                    x2 = 0;
                    CountX = 0;
                    x3 += -1.2f;
                    CountY++;
                }
                Camera.transform.position = new Vector3(-2.6f, -2.5f, -6.4f);
                break;
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            Destroy(Taker.gameObject);
        }

    }
}
