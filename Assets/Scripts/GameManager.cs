using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance = null;
    public static GameManager instance
    {
        get
        {
            return Instance;
        }
    }
    void Awake()
    {
        if (Instance)
        {
            DestroyImmediate(gameObject);
            return;
        }
        if (((float)Screen.width / Screen.height).Equals((float)16 / 9) == false) Screen.SetResolution(1920, 1080, Screen.fullScreen);
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
