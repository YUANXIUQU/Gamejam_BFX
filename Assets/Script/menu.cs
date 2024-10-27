using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void SrtTutorial()
    {
        SceneManager.LoadSceneAsync("Tutorial");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
