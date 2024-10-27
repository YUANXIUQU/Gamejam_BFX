using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void SrtTutorial()
    {
        SceneManager.LoadSceneAsync(6);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
