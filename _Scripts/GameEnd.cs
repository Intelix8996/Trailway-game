using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets._2D
{
    public class GameEnd : MonoBehaviour
    {

        public Text WinText;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag != "Player")
            {
                WinText.GetComponent<Text>().enabled = true;
                WinText.GetComponent<Animator>().enabled = true;
                GetComponent<PlatformerCharacter2D>().enabled = false;
                GetComponent<Platformer2DUserControl>().enabled = false;
            }

        }

        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.Tab))
            {
                Application.LoadLevel(0);
            }
        }


    }
}
