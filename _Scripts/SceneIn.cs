using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneIn : MonoBehaviour
{

    public static bool sceneEnd2;
    public float fadeSpeed2 = 1.5f;
    private Image _image2;
    private bool sceneStarting2;


    void Awake()
    {
        _image2 = GetComponent<Image>();
        _image2.enabled = true;
        sceneStarting2 = true;
    }

    void Update()
    {
        if (sceneStarting2) StartScene2();
    }

    void StartScene2()
    {
        _image2.color = Color.Lerp(_image2.color, Color.clear, fadeSpeed2 * Time.deltaTime);

        if (_image2.color.a <= 0.01f)
        {
            _image2.color = Color.clear;
            _image2.enabled = false;
            sceneStarting2 = false;
        }
    }

}