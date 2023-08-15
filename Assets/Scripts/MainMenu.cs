using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string FirstScene;
    public void StartGame()
    {
        SceneManager.LoadScene(FirstScene);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
