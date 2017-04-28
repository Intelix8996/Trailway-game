using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneInOut : MonoBehaviour
{

    public static bool sceneEnd;
    public float fadeSpeed = 1.5f;
    public Loader Loader;
    private Image _image;
    private bool sceneStarting;


    void Awake()
    {
        _image = GetComponent<Image>();
        _image.enabled = true;
        sceneStarting = true;
        sceneEnd = false;
    }

    void Update()
    {
        if (Loader.a > 1) sceneEnd = true;
        if (sceneStarting) StartScene();
        if (sceneEnd) EndScene();
    }

    void StartScene()
    {
        _image.color = Color.Lerp(_image.color, Color.clear, fadeSpeed * Time.deltaTime);

        if (_image.color.a <= 0.01f)
        {
            _image.color = Color.clear;
            _image.enabled = false;
            sceneStarting = false;
        }
    }

    void EndScene()
    {
        _image.enabled = true;
        _image.color = Color.Lerp(_image.color, Color.black, fadeSpeed * Time.deltaTime);

        if (_image.color.a >= 0.95f)
        {
            _image.color = Color.black;
            Application.LoadLevel(1);
        }
    }
}