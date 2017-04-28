using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets._2D
{

    public class RobotMove : MonoBehaviour
    {

        public GameObject[] MazeParts;


        private void FixedUpdate()
        {

            MazeParts = GameObject.FindGameObjectsWithTag("MazePart");

            if (Input.GetKey(KeyCode.Return))
            {
                GetComponent<PlatformerCharacter2D>().enabled = true;
                GetComponent<Platformer2DUserControl>().enabled = true;
                
                foreach (GameObject MzPrt in MazeParts)
                {
                    MzPrt.GetComponent<MazeRotate>().enabled = false;
                }

            }

            if (Input.GetKey(KeyCode.R))
            {
                Application.LoadLevel(1);
            }
        }


    }

}
