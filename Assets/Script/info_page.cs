using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class info_page : MonoBehaviour
{
    public GameObject page;
    void Start()
    {
        
    }

    public void Replay()
    {
        Time.timeScale = 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        page.SetActive(false);
        

    }

    public void backtoMenu()
    {
        SceneManager.LoadScene(0);
        page.SetActive(false);
    }
}
