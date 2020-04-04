using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private SceneSwitcher _sceneSwitcher;

    void Start()
    {
        Debug.Log("startup");
        _sceneSwitcher = new SceneSwitcher();
    }

    public void StartGame()
    {
        Debug.Log("start");
        _sceneSwitcher.LoadScene("Main");
    }

    public void ExitGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }

}
